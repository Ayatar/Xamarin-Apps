using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace _25042024MobilProgramlama2_FormlarArasiDegisken_
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button btnGoster;
        private EditText txtAdSoyad, txtTelefon;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            txtAdSoyad = FindViewById<EditText>(Resource.Id.editText2);
            txtTelefon = FindViewById<EditText>(Resource.Id.editText3);
            btnGoster = FindViewById<Button>(Resource.Id.button1);
            btnGoster.Click += BtnGoster_Click;
        }

        public void BtnGoster_Click(object sender, System.EventArgs e)
        {
            // BURASI ÖMNEMLİ SINAV. (ÇİZGİ İÇİNDEKİLER)
            //-------------------------------------------------
            var kyrintent = new Android.Content.Intent(this,typeof(Activity1)); // this = bu formdaki classları kullan.
            kyrintent.PutExtra("Ad Soyad",txtAdSoyad.Text);
            kyrintent.PutExtra("Telefon", int.Parse(txtTelefon.Text));
            StartActivity(kyrintent);
            //-------------------------------------------------
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}