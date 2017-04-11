using System;

using UIKit;

namespace AlternateIconsXamarin
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		private void changeAppIcon(String iconName)
		{
			if (UIApplication.SharedApplication.SupportsAlternateIcons)
			{
				Console.WriteLine("App Icon can be changed");
			}
			else 
			{ 
				Console.WriteLine("App Icon cannot be changed");
				return;
			}

			UIApplication.SharedApplication.SetAlternateIconName(iconName, (err) =>
			{
				Console.WriteLine("Error changing the icon: {0}", err);
			});
		}

		partial void DefaultButton_TouchUpInside(UIButton sender)
		{
			changeAppIcon(null);
		}

		partial void DarkThemeButton_TouchUpInside(UIButton sender)
		{
            changeAppIcon("propelicsDarkTheme");
		}

		partial void LightThemeButton_TouchUpInside(UIButton sender)
		{
            changeAppIcon("propelicsLightTheme");
		}
	}
}
