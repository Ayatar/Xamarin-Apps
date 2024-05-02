using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Text.Format;
using Android.Widget;
using AndroidX.AppCompat.App;
using Xamarin.Essentials;

namespace donanimKontrolu
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView txtKonum;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Button btnTitret = FindViewById<Button>(Resource.Id.button1);
            Button btnFlashAc = FindViewById<Button>(Resource.Id.button2);
            Button btnFlashKapat = FindViewById<Button>(Resource.Id.button3);
            Button btnKonumAl = FindViewById<Button>(Resource.Id.button4);
            txtKonum = FindViewById<TextView>(Resource.Id.textView1);
            btnKonumAl.Click += BtnKonumAl_Click;
            btnFlashAc.Click += BtnFlashAc_Click;
            btnFlashKapat.Click += BtnFlashKapat_Click;
            btnTitret.Click += BtnTitret_Click;
        }

        private async void BtnKonumAl_Click(object sender, EventArgs e)
        {
            var location = await Geolocation.GetLocationAsync(
                new GeolocationRequest(GeolocationAccuracy.Default , TimeSpan.FromMinutes(1)));
            txtKonum.Text = "North: " + location.Latitude + ", East: " + location.Longitude + ", Altitude: " + location.Altitude;
                
        }

        private async void BtnFlashKapat_Click(object sender, EventArgs e)
        {
            await Flashlight.TurnOffAsync();
        }

        private async void BtnFlashAc_Click(object sender, EventArgs e)
        {
            await Flashlight.TurnOnAsync(); // await işlemi bekliyor en uygun anda açıyor. Donanımlarda gerekli!!
        }

        private void BtnTitret_Click(object sender, System.EventArgs e)
        {
            var beklemeSüresi = TimeSpan.FromSeconds(10);
            Vibration.Vibrate(beklemeSüresi);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}