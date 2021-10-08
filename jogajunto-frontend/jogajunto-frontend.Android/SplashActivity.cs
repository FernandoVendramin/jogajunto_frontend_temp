using Android.App;
using Android.Content;
using Android.OS;
using System.Threading.Tasks;

namespace jogajunto_frontend.Droid
{
    [Activity(Theme = "@style/MainTheme.Splash", MainLauncher = true, NoHistory = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            new Task(async () =>
            {
                await Task.Delay(3000);
                StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            }).Start();
        }
    }
}