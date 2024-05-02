using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using Xamarin.Essentials;


namespace hardwareControl
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText txtTelNo, txtMesaj;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
             txtTelNo = FindViewById<EditText>(Resource.Id.editText1);
             txtMesaj = FindViewById<EditText>(Resource.Id.editText2);
            Button btnSms = FindViewById<Button>(Resource.Id.button1);
            btnSms.Click += BtnSms_Click;
        }

        private async void BtnSms_Click(object sender, System.EventArgs e)
        {
            var message = new SmsMessage(txtMesaj.Text, new[] {txtTelNo.Text });
            await Sms.ComposeAsync(message);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}