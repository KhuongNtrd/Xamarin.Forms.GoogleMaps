using System;
using Android.App;
using Android.Runtime;

namespace XFGoogleMapSample.Droid
{
    [Application]
    [MetaData("com.google.android.maps.v2.API_KEY",
              Value = "")]
    public class MyApp : Application
    {
        public MyApp(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}

