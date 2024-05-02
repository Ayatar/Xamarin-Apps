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

namespace _25042024MobilProgramlama2_FormlarArasiDegisken_
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout1);
            string adsoyad = Intent.GetStringExtra("Ad Soyad");
            int telNo = Intent.GetIntExtra("Telefon", 1);

            TextView txtAdSoyad = FindViewById<TextView>(Resource.Id.textView2);
            TextView txtTelNo = FindViewById<TextView>(Resource.Id.textView3);

            txtAdSoyad.Text = adsoyad;   
            txtTelNo.Text = Convert.ToString(telNo);


        }
    }
}