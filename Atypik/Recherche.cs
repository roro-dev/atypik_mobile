using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Support.V7.Widget;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views.Autofill;
using Android.Widget;
using static Android.Support.V7.Widget.SearchView;

namespace Atypik
{
    [Activity(Label = "Recherche", Theme = "@style/AppTheme", MainLauncher =true)]
    public class Recherche : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

                SetContentView(Resource.Layout.Recherche);

                      
   
        }
    }
}