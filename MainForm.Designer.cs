namespace Time2Stretch
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			SettingsOnStartUpCheckbox = new CheckBox();
			TimeBetweenBreaksLabel = new Label();
			TimeBetweenBreaksMinutesTextbox = new TextBox();
			NotificationMessageLabel = new Label();
			AddImagesCheckbox = new CheckBox();
			NotificationMessageTextbox = new TextBox();
			label6 = new Label();
			OnBreakLabel = new Label();
			TimeLeftLabel = new Label();
			TimeBetweenBreaksHoursLabel = new Label();
			TimeBetweenBreaksMinutesLabel = new Label();
			SkipBreakButton = new Button();
			TimeBetweenBreaksHoursTextbox = new TextBox();
			BreakDurationHoursTextbox = new TextBox();
			BreakDurationMinutesLabel = new Label();
			BreakDurationHoursLabel = new Label();
			BreakDurationMinutesTextbox = new TextBox();
			BreakDurationLabel = new Label();
			ApplyTimersButton = new Button();
			SuspendLayout();
			// 
			// SettingsOnStartUpCheckbox
			// 
			SettingsOnStartUpCheckbox.AutoSize = true;
			SettingsOnStartUpCheckbox.BackColor = Color.Transparent;
			SettingsOnStartUpCheckbox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			SettingsOnStartUpCheckbox.ForeColor = Color.Black;
			SettingsOnStartUpCheckbox.Location = new Point(16, 19);
			SettingsOnStartUpCheckbox.Margin = new Padding(3, 4, 3, 4);
			SettingsOnStartUpCheckbox.Name = "SettingsOnStartUpCheckbox";
			SettingsOnStartUpCheckbox.Size = new Size(304, 24);
			SettingsOnStartUpCheckbox.TabIndex = 0;
			SettingsOnStartUpCheckbox.Text = "Open this window on application startup";
			SettingsOnStartUpCheckbox.UseVisualStyleBackColor = false;
			SettingsOnStartUpCheckbox.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// TimeBetweenBreaksLabel
			// 
			TimeBetweenBreaksLabel.AutoSize = true;
			TimeBetweenBreaksLabel.Location = new Point(12, 73);
			TimeBetweenBreaksLabel.Name = "TimeBetweenBreaksLabel";
			TimeBetweenBreaksLabel.Size = new Size(157, 20);
			TimeBetweenBreaksLabel.TabIndex = 2;
			TimeBetweenBreaksLabel.Text = "Time between breaks:";
			TimeBetweenBreaksLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// TimeBetweenBreaksMinutesTextbox
			// 
			TimeBetweenBreaksMinutesTextbox.Location = new Point(218, 70);
			TimeBetweenBreaksMinutesTextbox.Margin = new Padding(3, 4, 3, 4);
			TimeBetweenBreaksMinutesTextbox.Name = "TimeBetweenBreaksMinutesTextbox";
			TimeBetweenBreaksMinutesTextbox.Size = new Size(29, 27);
			TimeBetweenBreaksMinutesTextbox.TabIndex = 4;
			TimeBetweenBreaksMinutesTextbox.TextChanged += TimeBetweenBreaksMinutesTextbox_TextChanged;
			// 
			// NotificationMessageLabel
			// 
			NotificationMessageLabel.AutoSize = true;
			NotificationMessageLabel.Location = new Point(16, 127);
			NotificationMessageLabel.Name = "NotificationMessageLabel";
			NotificationMessageLabel.Size = new Size(156, 20);
			NotificationMessageLabel.TabIndex = 9;
			NotificationMessageLabel.Text = "Notification message:";
			// 
			// AddImagesCheckbox
			// 
			AddImagesCheckbox.AutoSize = true;
			AddImagesCheckbox.Location = new Point(16, 162);
			AddImagesCheckbox.Margin = new Padding(3, 4, 3, 4);
			AddImagesCheckbox.Name = "AddImagesCheckbox";
			AddImagesCheckbox.Size = new Size(208, 24);
			AddImagesCheckbox.TabIndex = 10;
			AddImagesCheckbox.Text = "Add images to notification";
			AddImagesCheckbox.UseVisualStyleBackColor = true;
			// 
			// NotificationMessageTextbox
			// 
			NotificationMessageTextbox.Location = new Point(174, 124);
			NotificationMessageTextbox.Margin = new Padding(3, 4, 3, 4);
			NotificationMessageTextbox.Name = "NotificationMessageTextbox";
			NotificationMessageTextbox.Size = new Size(537, 27);
			NotificationMessageTextbox.TabIndex = 11;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(57, 190);
			label6.Name = "label6";
			label6.Size = new Size(0, 20);
			label6.TabIndex = 12;
			// 
			// OnBreakLabel
			// 
			OnBreakLabel.AutoSize = true;
			OnBreakLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			OnBreakLabel.ForeColor = Color.Red;
			OnBreakLabel.Location = new Point(293, 190);
			OnBreakLabel.Name = "OnBreakLabel";
			OnBreakLabel.Size = new Size(131, 25);
			OnBreakLabel.TabIndex = 13;
			OnBreakLabel.Text = "Not on break";
			OnBreakLabel.TextAlign = ContentAlignment.MiddleCenter;
			OnBreakLabel.Click += label7_Click;
			// 
			// TimeLeftLabel
			// 
			TimeLeftLabel.AutoSize = true;
			TimeLeftLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			TimeLeftLabel.ForeColor = Color.Black;
			TimeLeftLabel.Location = new Point(295, 222);
			TimeLeftLabel.Name = "TimeLeftLabel";
			TimeLeftLabel.Size = new Size(130, 20);
			TimeLeftLabel.TabIndex = 14;
			TimeLeftLabel.Text = "Time left: 00h00m";
			TimeLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
			TimeLeftLabel.Click += TimeLeftLabel_Click;
			// 
			// TimeBetweenBreaksHoursLabel
			// 
			TimeBetweenBreaksHoursLabel.AutoSize = true;
			TimeBetweenBreaksHoursLabel.Location = new Point(200, 73);
			TimeBetweenBreaksHoursLabel.Name = "TimeBetweenBreaksHoursLabel";
			TimeBetweenBreaksHoursLabel.Size = new Size(18, 20);
			TimeBetweenBreaksHoursLabel.TabIndex = 15;
			TimeBetweenBreaksHoursLabel.Text = "h";
			TimeBetweenBreaksHoursLabel.TextAlign = ContentAlignment.MiddleLeft;
			TimeBetweenBreaksHoursLabel.Click += TimeBetweenBreaksHoursLabel_Click;
			// 
			// TimeBetweenBreaksMinutesLabel
			// 
			TimeBetweenBreaksMinutesLabel.AutoSize = true;
			TimeBetweenBreaksMinutesLabel.Location = new Point(248, 73);
			TimeBetweenBreaksMinutesLabel.Name = "TimeBetweenBreaksMinutesLabel";
			TimeBetweenBreaksMinutesLabel.Size = new Size(22, 20);
			TimeBetweenBreaksMinutesLabel.TabIndex = 16;
			TimeBetweenBreaksMinutesLabel.Text = "m";
			TimeBetweenBreaksMinutesLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// SkipBreakButton
			// 
			SkipBreakButton.Location = new Point(294, 253);
			SkipBreakButton.Margin = new Padding(3, 4, 3, 4);
			SkipBreakButton.Name = "SkipBreakButton";
			SkipBreakButton.Size = new Size(132, 31);
			SkipBreakButton.TabIndex = 17;
			SkipBreakButton.Text = "Skip to break";
			SkipBreakButton.UseVisualStyleBackColor = true;
			// 
			// TimeBetweenBreaksHoursTextbox
			// 
			TimeBetweenBreaksHoursTextbox.Location = new Point(171, 70);
			TimeBetweenBreaksHoursTextbox.Margin = new Padding(3, 4, 3, 4);
			TimeBetweenBreaksHoursTextbox.Name = "TimeBetweenBreaksHoursTextbox";
			TimeBetweenBreaksHoursTextbox.Size = new Size(29, 27);
			TimeBetweenBreaksHoursTextbox.TabIndex = 22;
			TimeBetweenBreaksHoursTextbox.TextChanged += T_TextChanged;
			// 
			// BreakDurationHoursTextbox
			// 
			BreakDurationHoursTextbox.Location = new Point(419, 70);
			BreakDurationHoursTextbox.Margin = new Padding(3, 4, 3, 4);
			BreakDurationHoursTextbox.Name = "BreakDurationHoursTextbox";
			BreakDurationHoursTextbox.Size = new Size(29, 27);
			BreakDurationHoursTextbox.TabIndex = 27;
			// 
			// BreakDurationMinutesLabel
			// 
			BreakDurationMinutesLabel.AutoSize = true;
			BreakDurationMinutesLabel.Location = new Point(496, 73);
			BreakDurationMinutesLabel.Name = "BreakDurationMinutesLabel";
			BreakDurationMinutesLabel.Size = new Size(22, 20);
			BreakDurationMinutesLabel.TabIndex = 26;
			BreakDurationMinutesLabel.Text = "m";
			BreakDurationMinutesLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// BreakDurationHoursLabel
			// 
			BreakDurationHoursLabel.AutoSize = true;
			BreakDurationHoursLabel.Location = new Point(448, 73);
			BreakDurationHoursLabel.Name = "BreakDurationHoursLabel";
			BreakDurationHoursLabel.Size = new Size(18, 20);
			BreakDurationHoursLabel.TabIndex = 25;
			BreakDurationHoursLabel.Text = "h";
			BreakDurationHoursLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// BreakDurationMinutesTextbox
			// 
			BreakDurationMinutesTextbox.Location = new Point(466, 70);
			BreakDurationMinutesTextbox.Margin = new Padding(3, 4, 3, 4);
			BreakDurationMinutesTextbox.Name = "BreakDurationMinutesTextbox";
			BreakDurationMinutesTextbox.Size = new Size(29, 27);
			BreakDurationMinutesTextbox.TabIndex = 24;
			// 
			// BreakDurationLabel
			// 
			BreakDurationLabel.AutoSize = true;
			BreakDurationLabel.Location = new Point(295, 73);
			BreakDurationLabel.Name = "BreakDurationLabel";
			BreakDurationLabel.Size = new Size(117, 20);
			BreakDurationLabel.TabIndex = 23;
			BreakDurationLabel.Text = "Break Duration:";
			BreakDurationLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// ApplyTimersButton
			// 
			ApplyTimersButton.Location = new Point(539, 68);
			ApplyTimersButton.Margin = new Padding(3, 4, 3, 4);
			ApplyTimersButton.Name = "ApplyTimersButton";
			ApplyTimersButton.Size = new Size(123, 31);
			ApplyTimersButton.TabIndex = 28;
			ApplyTimersButton.Text = "Apply Timers";
			ApplyTimersButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.WhiteSmoke;
			ClientSize = new Size(723, 318);
			Controls.Add(ApplyTimersButton);
			Controls.Add(BreakDurationHoursTextbox);
			Controls.Add(BreakDurationMinutesLabel);
			Controls.Add(BreakDurationHoursLabel);
			Controls.Add(BreakDurationMinutesTextbox);
			Controls.Add(BreakDurationLabel);
			Controls.Add(TimeBetweenBreaksHoursTextbox);
			Controls.Add(SkipBreakButton);
			Controls.Add(TimeBetweenBreaksMinutesLabel);
			Controls.Add(TimeBetweenBreaksHoursLabel);
			Controls.Add(TimeLeftLabel);
			Controls.Add(OnBreakLabel);
			Controls.Add(label6);
			Controls.Add(NotificationMessageTextbox);
			Controls.Add(AddImagesCheckbox);
			Controls.Add(NotificationMessageLabel);
			Controls.Add(TimeBetweenBreaksMinutesTextbox);
			Controls.Add(TimeBetweenBreaksLabel);
			Controls.Add(SettingsOnStartUpCheckbox);
			Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			ForeColor = Color.Black;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 4, 3, 4);
			Name = "MainForm";
			Text = "Time2Stretch Settings";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CheckBox SettingsOnStartUpCheckbox;
		private Label TimeBetweenBreaksLabel;
		private TextBox TimeBetweenBreaksMinutesTextbox;
		private Label NotificationMessageLabel;
		private CheckBox AddImagesCheckbox;
		private TextBox NotificationMessageTextbox;
		private Label label6;
		private Label OnBreakLabel;
		private Label TimeLeftLabel;
		private Label TimeBetweenBreaksHoursLabel;
		private Label TimeBetweenBreaksMinutesLabel;
		private Button SkipBreakButton;
		private TextBox TimeBetweenBreaksHoursTextbox;
		private TextBox BreakDurationHoursTextbox;
		private Label BreakDurationMinutesLabel;
		private Label BreakDurationHoursLabel;
		private TextBox BreakDurationMinutesTextbox;
		private Label BreakDurationLabel;
		private Button ApplyTimersButton;
	}
}