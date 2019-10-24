SetContentView (Resource.Layout.Main);
 
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Tutorial Toolbar";
