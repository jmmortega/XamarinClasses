using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamarinClasses.MyFirstProjectAndroid
{
    [Activity(Label = "XamarinClasses.MyFirstProjectAndroid", MainLauncher = true, Icon = "@drawable/icon", WindowSoftInputMode = SoftInput.StateAlwaysHidden)]        
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            

            button.Click += delegate 
            {
                new DatePickerDialog(this,
                    (s, e) =>
                    {

                    }, 2015, 11, 26).Show();                               
            };            
        }

        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}

