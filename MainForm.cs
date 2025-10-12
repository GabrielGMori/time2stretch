using System.Diagnostics;
using System.Reflection;
using Time2Stretch.Model;

namespace Time2Stretch
{
	public partial class MainForm : Form
	{
		private readonly NotificationManager notificationManager = new();
		private BreakTimer clock = new(0.1, Properties.Settings.Default.BreakDurationInMinutes, false);

		private readonly NotifyIcon trayIcon;
		private readonly ContextMenuStrip trayMenu;

		private bool allowVisible = false;
		private bool allowClose = false;

		public MainForm()
		{
			if (Properties.Settings.Default.OpenSettingsOnStartup == true)
			{
				allowVisible = true;
			}

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

			UpdateSettingsValues();
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
			base.OnFormClosing(e);
		}

		private void OnSettingsClicked(object? sender, EventArgs e) => ShowSettings();
		private void ShowSettings()
		{
			allowVisible = true;
			Show();
		}

		private void OnExitClicked(object? sender, EventArgs e)
		{
			trayIcon.Visible = false;
			allowClose = true;
			Application.Exit();
		}

		private void UpdateSettingsValues()
		{
			SettingsOnStartUpCheckbox.Checked = Properties.Settings.Default.OpenSettingsOnStartup;

			int TimeBetweenBreaksHours = Properties.Settings.Default.TimeBetweenBreaksInMinutes / 60;
			int TimeBetweenBreaksMinutes = Properties.Settings.Default.TimeBetweenBreaksInMinutes - TimeBetweenBreaksHours*60;
			TimeBetweenBreaksHoursTextbox.Text = TimeBetweenBreaksHours.ToString();
			TimeBetweenBreaksMinutesTextbox.Text = TimeBetweenBreaksMinutes.ToString();

			int BreakDurationHours = Properties.Settings.Default.BreakDurationInMinutes / 60;
			int BreakDurationMinutes = Properties.Settings.Default.BreakDurationInMinutes - BreakDurationHours * 60;
			BreakDurationHoursTextbox.Text = BreakDurationHours.ToString();
			BreakDurationMinutesTextbox.Text = BreakDurationMinutes.ToString();

			NotificationMessageTextbox.Text = Properties.Settings.Default.NotificationMessage;
			AddImagesCheckbox.Checked = Properties.Settings.Default.AddImagesToNotification;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void TimeBetweenBreaksHoursLabel_Click(object sender, EventArgs e)
		{

		}

		private void TimeBetweenBreaksMinutesTextbox_TextChanged(object sender, EventArgs e)
		{

		}

		private void TimeLeftLabel_Click(object sender, EventArgs e)
		{

		}

		private void T_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
