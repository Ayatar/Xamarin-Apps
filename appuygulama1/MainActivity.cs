using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;

namespace appuygulama1
{
    [Activity(Label = "My Application", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private static readonly int NOTIFICATION_ID = 1000;
        private static readonly string CHANNEL_ID = "location_notification";
        private int count = 0;

        EditText textView1, textView2, textView3;
        Button button1, button2;
        TextView textView4;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            textView1 = FindViewById<EditText>(Resource.Id.textView1);
            textView2 = FindViewById<EditText>(Resource.Id.textView2);
            textView3 = FindViewById<EditText>(Resource.Id.textView3);
            textView4 = FindViewById<TextView>(Resource.Id.textView4);
            button1 = FindViewById<Button>(Resource.Id.button1);
            button2 = FindViewById<Button>(Resource.Id.button2);
            
            button1.Click += button1_Click;
            button2.Click += button2_Click;


        }
        private void button1_Click(object sender, System.EventArgs e)
        {

            textView4.Text = Convert.ToString(hesapla());




        }
        private void button2_Click(object sender, System.EventArgs e)
        {

            textView4.Text = Convert.ToString(hesapla2());

           


        }

        public  int hesapla2 ()
        {
            int result = int.Parse(textView1.Text) + int.Parse(textView2.Text) + int.Parse(textView3.Text);
            return result;
        }

        public int hesapla()
        {
            
            int result = int.Parse(textView1.Text) * int.Parse(textView2.Text) * int.Parse(textView3.Text);
            return result;

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public interface INotificationManager
        {
            event EventHandler NotificationReceived;
            void Initialize();
            void SendNotification(string title, string message, DateTime? notifyTime = null);
            void ReceiveNotification(string title, string message);
        }
    }
}