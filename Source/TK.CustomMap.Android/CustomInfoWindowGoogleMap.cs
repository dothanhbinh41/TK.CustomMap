using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

namespace TK.CustomMap.Droid
{
    public class CustomInfoWindowGoogleMap : Java.Lang.Object, GoogleMap.IInfoWindowAdapter
    {
        private readonly Context context;

        public CustomInfoWindowGoogleMap(Context context)
        {
            this.context = context;
        }
        public View GetInfoContents(Marker marker)
        { 
            var title = new TextView(context)
            {
                Text = marker.Title
            };
            title.SetTextSize(Android.Util.ComplexUnitType.Sp, 15);
            title.SetTextColor(Color.ParseColor("#2D6BAE")); 
             
            return title;
        }

        public View GetInfoWindow(Marker marker)
        {
            return null;
        }
    }
}