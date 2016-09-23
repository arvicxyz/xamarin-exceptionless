using System;
using Exceptionless;

namespace XamarinExceptionless
{
    public static class ExceptionlessHelper
    {
        public static void Initialize(string apiKey)
        {
            ExceptionlessClient.Default.Startup(apiKey);
        }

        public static void SubmitException(Exception ex)
        {
            ex.ToExceptionless().Submit();
        }
    }
}
