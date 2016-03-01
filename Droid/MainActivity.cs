using System.Globalization;
using Android.App;
using Android.Widget;
using Android.OS;
using XamarinShared;

namespace Droid
{
    [Activity(Label = "Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += (sender, args) =>
            {
                var left = int.Parse(FindViewById<EditText>(Resource.Id.left).Text);
                var right = int.Parse(FindViewById<EditText>(Resource.Id.right).Text);
                FindViewById<TextView>(Resource.Id.result).Text = CLib.Add(left, right)
                    .ToString(CultureInfo.InvariantCulture);
            };
        }
    }
}

