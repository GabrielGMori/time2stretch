using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Time2Stretch.Core;

namespace Time2Stretch
{
	public partial class MainForm : Form, INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		private TimerManager clock = new(Properties.Settings.Default.MinutesBetweenBreaks, Properties.Settings.Default.BreakDurationInMinutes, false);

		private readonly NotifyIcon trayIcon;
		private readonly ContextMenuStrip trayMenu;

		private bool allowVisible = false;
		private bool allowClose = false;

		private string timeUntilBreakStatusChange = "Time left: Loading...";
		public string TimeUntilBreakStatusChange
		{
			get => timeUntilBreakStatusChange;
			set
			{
				timeUntilBreakStatusChange = value;
				OnPropertyChanged();
			}
		}

		public MainForm()
		{
			if (Properties.Settings.Default.OpenSettingsOnStartup == true) allowVisible = true;
			InitializeComponent();

			trayMenu = new ContextMenuStrip();
			trayMenu.Items.Add("Settings", null, OnSettingsClicked);
			_ = trayMenu.Items.Add("Exit", null, OnExitClicked);

			trayIcon = new NotifyIcon
			{
				Text = "Time2Stretch",
				ContextMenuStrip = trayMenu,
				Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location),
				Visible = true
			};

			trayIcon.Visible = true;
			trayIcon.DoubleClick += (s, e) => ShowSettings();

			clock.OnTick += UpdateOnTick;
			clock.OnBreakStatusChange += UpdateOnBreakStatusChange;

			UpdateSettingsValues();
		}

		private void UpdateSettingsValues()
		{
			SettingsOnStartUpCheckbox.Checked = Properties.Settings.Default.OpenSettingsOnStartup;

			int TimeBetweenBreaksHours = Convert.ToInt32(Math.Floor(Properties.Settings.Default.MinutesBetweenBreaks / 60));
			double TimeBetweenBreaksMinutes = Properties.Settings.Default.MinutesBetweenBreaks - TimeBetweenBreaksHours * 60;
			TimeBetweenBreaksHoursTextbox.Text = TimeBetweenBreaksHours.ToString();
			TimeBetweenBreaksMinutesTextbox.Text = TimeBetweenBreaksMinutes.ToString();

			int BreakDurationHours = Convert.ToInt32(Math.Floor(Properties.Settings.Default.BreakDurationInMinutes / 60));
			double BreakDurationMinutes = Properties.Settings.Default.BreakDurationInMinutes - BreakDurationHours * 60;
			BreakDurationHoursTextbox.Text = BreakDurationHours.ToString();
			BreakDurationMinutesTextbox.Text = BreakDurationMinutes.ToString();

			BreakStartMessageTextbox.Text = Properties.Settings.Default.BreakStartMessage;
			BreakEndMessageTextbox.Text = Properties.Settings.Default.BreakEndMessage;
			AddImagesCheckbox.Checked = Properties.Settings.Default.AddImagesToNotification;

			TimeLeftLabel.DataBindings.Add("Text", this, nameof(TimeUntilBreakStatusChange));
		}

		protected override void SetVisibleCore(bool value)
		{
			if (!allowVisible)
			{
				value = false;
				if (!IsHandleCreated) CreateHandle();
			}
			base.SetVisibleCore(value);
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (!allowClose)
			{
				Hide();
				e.Cancel = true;
			}
			else
			{
				NotificationManager.ClearNotifications();
			}
			base.OnFormClosing(e);
		}

		private void OnSettingsClicked(object? sender, EventArgs e) => ShowSettings();
		private void ShowSettings()
		{
			allowVisible = true;
			Show();
		}

		private void OnExitClicked(object? sender, EventArgs e) => CloseApp();
		private void CloseApp()
		{
			trayIcon.Visible = false;
			allowClose = true;
			Application.Exit();
		}

		protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private void UpdateOnTick(object? sender, EventArgs e)
		{
			TimeSpan time = clock.GetTimeUntilBreakStatusChange();
			TimeUntilBreakStatusChange = $"🕑 Time left: {time.Hours}h{(time.Minutes < 10 ? "0" : "")}{time.Minutes}m{(time.Seconds < 10 ? "0" : "")}{time.Seconds}s";
		}

		private void UpdateOnBreakStatusChange(object? sender, EventArgs e)
		{
			OnBreakLabel.Text = clock.OnBreak == false ? "❌ Not on break" : "✅ On break";
			OnBreakLabel.ForeColor = clock.OnBreak == false ? Color.Red : Color.Green;
			SkipBreakButton.Text = clock.OnBreak == false ? "Skip to break" : "Skip break";

			string title = clock.OnBreak == false ? "Break ended" : "Break started";
			string text = clock.OnBreak == false ? Properties.Settings.Default.BreakEndMessage : Properties.Settings.Default.BreakStartMessage;

			string imagesDirectory = Path.Combine(AppContext.BaseDirectory, "Assets");
			string imagePath = clock.OnBreak == false ? Path.Combine(imagesDirectory, "Logo.ico") : Path.Combine(imagesDirectory, "Logo-Break.ico");

			if (Properties.Settings.Default.AddImagesToNotification == true) NotificationManager.Send(title, text, imagePath);
			else NotificationManager.Send(title, text);
		}

		private void SettingsOnStartUpCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.OpenSettingsOnStartup = SettingsOnStartUpCheckbox.Checked;
			Properties.Settings.Default.Save();
		}

		private void ApplyTimersButton_Click(object sender, EventArgs e)
		{
			double newMinutesBetweenBreaks = 0;
			double newBreakDurationInMinutes = 0;
			try
			{
				newMinutesBetweenBreaks = double.Parse(TimeBetweenBreaksHoursTextbox.Text) * 60 + double.Parse(TimeBetweenBreaksMinutesTextbox.Text);
				newBreakDurationInMinutes = double.Parse(BreakDurationHoursTextbox.Text) * 60 + double.Parse(BreakDurationMinutesTextbox.Text);
			}
			catch (FormatException)
			{
				InvalidTimesLabel.Visible = true;
				return;
			}

			InvalidTimesLabel.Visible = false;

			Properties.Settings.Default.MinutesBetweenBreaks = newMinutesBetweenBreaks;
			Properties.Settings.Default.BreakDurationInMinutes = newBreakDurationInMinutes;
			Properties.Settings.Default.Save();

			clock.Dispose();
			clock = new(newMinutesBetweenBreaks, newBreakDurationInMinutes, clock.OnBreak);
			clock.OnTick += UpdateOnTick;
			clock.OnBreakStatusChange += UpdateOnBreakStatusChange;
		}

		private void BreakStartMessageTextbox_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.BreakStartMessage = BreakStartMessageTextbox.Text;
			Properties.Settings.Default.Save();
		}

		private void BreakEndMessageTextbox_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.BreakEndMessage = BreakEndMessageTextbox.Text;
			Properties.Settings.Default.Save();
		}

		private void AddImagesCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.AddImagesToNotification = AddImagesCheckbox.Checked;
			Properties.Settings.Default.Save();
		}

		private void SkipBreakButton_Click(object sender, EventArgs e)
		{
			clock.ChangeBreakStatus();
		}

		private void PauseStartButton_Click(object sender, EventArgs e)
		{
			if (clock.Paused == false) clock.Pause();
			else clock.Start();
			PauseStartButton.Text = clock.Paused == false ? "Pause" : "Start";
		}

		private void ExitAppButton_Click(object sender, EventArgs e) => CloseApp();
	}
}
