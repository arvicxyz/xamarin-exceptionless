using System.Diagnostics;
using Java.Lang;

namespace XamarinExceptionless.Droid
{
    public class CustomExceptionHandler : Java.Lang.Object, Thread.IUncaughtExceptionHandler
    {
        public void UncaughtException(Thread t, Throwable e)
        {
            // Submit an exception to the Exceptionless server
            ExceptionlessHelper.SubmitException(e);

            // Display error message for local debugging purposes
            Debug.WriteLine(e);
        }
    }
}
