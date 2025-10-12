using Microsoft.Toolkit.Uwp.Notifications;

namespace Time2Stretch.Core
{
	internal class NotificationManager
	{
		public static void Send(string title, string text, string imagePath)
		{
			BaseNotification(title, text).AddAppLogoOverride(new Uri(imagePath, UriKind.Absolute)).Show();
		}

		public static void Send(string title, string text)
		{
			BaseNotification(title, text).Show();
		}

		public static void ClearNotifications()
		{
			ToastNotificationManagerCompat.History.Clear();
		}

		private static ToastContentBuilder BaseNotification(string title, string text)
		{
			return new ToastContentBuilder().AddText(title).AddText(text).SetToastDuration(ToastDuration.Short);
		}
	}
}
