namespace Time2Stretch.Core
{
	internal class TimerManager : IDisposable
	{
		private readonly System.Windows.Forms.Timer timer = new();

		public double MinutesBetweenBreaks { get; set; }
		public double BreakDurationInMinutes { get; set; }

		public bool OnBreak { get; set; }
		public bool Paused { get; set; } = false;

		private DateTime lastBreakStatusChange = DateTime.Now;
		private DateTime lastPause = DateTime.Now;

		public event EventHandler? OnTick;
		public event EventHandler? OnBreakStatusChange;

		public TimerManager(double timeBetweenBreaksInMinutes, double breakDurationInMinutes, bool onBreak)
		{
			MinutesBetweenBreaks = timeBetweenBreaksInMinutes;
			BreakDurationInMinutes = breakDurationInMinutes;
			OnBreak = onBreak;

			timer.Interval = 1000;
			timer.Tick += OnTimeElapsed;
			timer.Start();
		}

		private void OnTimeElapsed(object? sender, EventArgs e)
		{
			TimeSpan timeSinceLastBreak = DateTime.Now - lastBreakStatusChange;

			OnTick?.Invoke(this, e);

			if (OnBreak == false && timeSinceLastBreak.TotalMinutes >= MinutesBetweenBreaks
				|| OnBreak == true && timeSinceLastBreak.TotalMinutes >= BreakDurationInMinutes)
			{
				ChangeBreakStatus();
			}
		}

		public void ChangeBreakStatus()
		{
			OnBreak = !OnBreak;
			OnBreakStatusChange?.Invoke(this, new EventArgs());
			lastBreakStatusChange = DateTime.Now;
		}

		public TimeSpan GetTimeUntilBreakStatusChange()
		{
			return OnBreak == false
				? lastBreakStatusChange.AddMinutes(MinutesBetweenBreaks) - DateTime.Now
				: lastBreakStatusChange.AddMinutes(BreakDurationInMinutes) - DateTime.Now;
		}

		public void Pause()
		{
			Paused = true;
			timer.Stop();
			lastPause = DateTime.Now;
		}

		public void Start()
		{
			Paused = false;
			timer.Start();
			lastBreakStatusChange = lastBreakStatusChange.Add(DateTime.Now - lastPause);
		}

		public void Dispose()
		{
			timer.Dispose();
		}
	}
}
