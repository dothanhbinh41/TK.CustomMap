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
            return null;
        }

        public View GetInfoWindow(Marker marker)
        {
            var layout = new LinearLayout(context)
            {
                Orientation = Orientation.Vertical
            };
            var title = new TextView(context)
            {
                Text = marker.Title,
                TextSize = context.ToPixels(12)
            }; 
            title.SetTextColor(Color.ParseColor("#2D6BAE"));
            var snippet = new TextView(context)
            {
                Text = marker.Snippet,
                TextSize = context.ToPixels(12)
            };
            snippet.SetTextColor(Color.ParseColor("#2D6BAE"));
              
            layout.AddView(title);
            layout.AddView(snippet);
            return layout;
        }
    }
}