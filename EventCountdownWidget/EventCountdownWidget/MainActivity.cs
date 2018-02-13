using Android.App;
using Android.Widget;
using Android.OS;

namespace EventCountdownWidget
{
    [Activity(Label = "EventCountdownWidget", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var digitalClock = FindViewById<DigitalClock>(Resource.Id.digitalClock);
            var digitalClock1 = FindViewById<DigitalClock>(Resource.Id.digitalClock1);
            digitalClock1.Visibility = Android.Views.ViewStates.Invisible;

            var btnShow = FindViewById<Button>(Resource.Id.btnShow);
            btnShow.Click += (s, e) =>
            {
                digitalClock1.Visibility = Android.Views.ViewStates.Visible;
                btnShow.Text = "Another Digital Clock";
            };
        }
    }
}

