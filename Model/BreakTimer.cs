using System.Diagnostics;
using System.Timers;

namespace Time2Stretch.Model
{
	internal class BreakTimer : IDisposable
	{
		private readonly System.Timers.Timer timer = new(1000);

		private readonly double timeBetweenBreaksInMinutes;
		private readonly double breakDurationInMinutes;
		private bool OnBreak { get; set; }
		private DateTime lastOnBreakChange = DateTime.Now;

		public event EventHandler? Tick;
		public event EventHandler? OnBreakChange;

		public BreakTimer(double timeBetweenBreaksInMinutes, double breakDurationInMinutes, bool onBreak)
		{
			this.timeBetweenBreaksInMinutes = timeBetweenBreaksInMinutes;
			this.breakDurationInMinutes = breakDurationInMinutes;
			OnBreak = onBreak;

			timer.Elapsed += OnTick;
			timer.AutoReset = true;
			timer.Start();
		}

		private void OnTick(object? sender, ElapsedEventArgs e)
		{
			TimeSpan totalElapsed = DateTime.Now - lastOnBreakChange;
			Debug.WriteLine(totalElapsed.TotalSeconds);

			if (OnBreak == true && totalElapsed.TotalMinutes >= timeBetweenBreaksInMinutes
				|| OnBreak == false && totalElapsed.TotalMinutes >= breakDurationInMinutes)
			{
				OnBreak = !OnBreak;
				OnBreakChange?.Invoke(this, e);
				lastOnBreakChange = DateTime.Now;
			}

			Tick?.Invoke(this, e);
		}

		public void Dispose()
		{
			timer.Dispose();
		}
	}
}
