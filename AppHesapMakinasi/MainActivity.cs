using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
namespace AppHesapMakinasi
{
    [Activity(Label = "Hesap Makinası", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText txtGiris1;
        Button btnTopla, btnCikar, btnBol, btnCarp;
        TextView txtSonuc;

        protected override void OnCreate(Bundle savedInstanceState)
        {


            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            //txt kısmı

            
            //btn kısmı
            btnTopla = FindViewById<Button>(Resource.Id.button4);
            btnCikar= FindViewById<Button>(Resource.Id.button8);
            btnBol=FindViewById<Button>(Resource.Id.button16);
            btnCarp=FindViewById<Button>(Resource.Id.button12);
            //text view kısmı
            
            //button click event kısmı
            
            btnCarp.Click += BtnCarp_Click; 
        }

        private void BtnCarp_Click(object sender, System.EventArgs e)
        {
            var text1 = "Merhaba";
            txtSonuc.Text= text1.ToString();
        }

       

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}