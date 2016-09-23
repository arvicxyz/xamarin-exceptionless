using Android.App;
using Android.OS;
using Android.Widget;
using Java.Lang;

namespace XamarinExceptionless.Droid
{
    [Activity(Label = "Exceptionless",
              MainLauncher = true,
              Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            // Initialize Exceptionless client before app startup
            ExceptionlessHelper.Initialize("your_api_key_here");

            // Set a the default exception handler to a custom one
            if (!(Thread.DefaultUncaughtExceptionHandler is CustomExceptionHandler))
            {
                Thread.DefaultUncaughtExceptionHandler = new CustomExceptionHandler();
            }

            Button button = FindViewById<Button>(Resource.Id.myButton);
            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}
