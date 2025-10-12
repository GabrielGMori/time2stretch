using Microsoft.Toolkit.Uwp.Notifications;

namespace Time2Stretch.Model
{
	internal class NotificationManager
	{
		public static void SendWithImage(string title, string text, string imagePath)
		{
			new ToastContentBuilder().AddText(title).AddText(text).AddAppLogoOverride(new Uri(imagePath, UriKind.Absolute)).Show();
		}

		public static void SendWithoutImage(string title, string text)
		{
			new ToastContentBuilder().AddText(title).AddText(text).Show();
		}
	}
}
