using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace TipCalc.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
	public partial class AppDelegate : FormsApplicationDelegate
    {
        // class-level declarations
        UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			LoadApplication (new App ());  // method is new in 1.3

			#if DEBUG
			Xamarin.Calabash.Start();
			#endif

			return base.FinishedLaunching (app, options);
		}
    }
}