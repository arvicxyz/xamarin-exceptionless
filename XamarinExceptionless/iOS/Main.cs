using System;
using System.Diagnostics;
using UIKit;

namespace XamarinExceptionless.iOS
{
    public class Application
    {
        static void Main(string[] args)
        {
            try
            {
                // Initialize Exceptionless client before app startup
                ExceptionlessHelper.Initialize("your_api_key_here");

                // Entry point of your Xamarin.iOS application
                UIApplication.Main(args, null, "AppDelegate");
            }
            catch (Exception ex)
            {
                // Submit an exception to the Exceptionless server
                ExceptionlessHelper.SubmitException(ex);

                // Display error message for local debugging purposes
                Debug.WriteLine(ex);
            }
        }
    }
}
