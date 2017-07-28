using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms.Platform.Android;

namespace TestApp.Droid
{
   [Activity(Label = "TestApp", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]//, Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
   public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity //FormsAppCompatActivity
   {
      protected override void OnCreate(Bundle bundle)
      {
         base.OnCreate(bundle);

         Xamarin.Forms.Forms.Init(this, bundle);
         LoadApplication(new App());
      }
   }
}

