using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlertDialog = Android.App.AlertDialog;

namespace _25042024MobilProgramlama
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout1);
            TextView txtgoster = FindViewById<TextView>(Resource.Id.textView1);
             txtgoster.Text = "Hoşgeldiniz";
             Button btnGoster = FindViewById<Button>(Resource.Id.button1);
             btnGoster.Click += BtnGoster_Click;
        }

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            // Sabit mesaj penceresi

            AlertDialog.Builder msg=new AlertDialog.Builder(this);
            AlertDialog uyari = msg.Create();
            uyari.SetTitle("Başlık");
            uyari.SetMessage("Yeni Form Açmak İster misiniz?");
            uyari.SetIcon(Android.Resource.Drawable.IcDialogAlert);
            uyari.SetButton("Evet", (c, s) =>
            {
                // Toast.MakeText(this, "Evet e Bastın", ToastLength.Long).Show();
                Toast.MakeText(this, "Yeni Form Açılıyor...", ToastLength.Short).Show();
                StartActivity(typeof(Activity2));
            });

            uyari.SetButton2("Hayır", (c, s) =>
            {
                //Toast.MakeText(this, "Hayır a Bastın", ToastLength.Short).Show();
            });
            uyari.Show();

        }
    }
}