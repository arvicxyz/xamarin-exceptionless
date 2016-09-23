using System;
using System.Diagnostics;
using Java.Lang;

namespace XamarinExceptionless.Droid
{
    public class CustomExceptionHandler : Thread.IUncaughtExceptionHandler
    {
        public CustomExceptionHandler()
        {
        }

        public IntPtr Handle
        {
            get { throw new NotImplementedException(); }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void UncaughtException(Thread t, Throwable e)
        {
            // Submit an exception to the Exceptionless server
            ExceptionlessHelper.SubmitException(e);

            // Display error message for local debugging purposes
            Debug.WriteLine(e);
        }
    }
}
