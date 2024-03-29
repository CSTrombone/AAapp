﻿using Android.App;
using AndroidX.Car.App;
using AndroidX.Car.App.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeControl.Platforms.Android.Auto.Sessions;

namespace YouTubeControl.Platforms.Android.Auto.Services
{
    [Service(Exported = true)]
    [IntentFilter(new string[] { "androidX.car.app.CarAppService" }, Categories = new[] { "androidx.car.app.category.POI" })]
    public class CarService : CarAppService
    {
        public override HostValidator CreateHostValidator()
        {
            return HostValidator.AllowAllHostsValidator;
        }

        public override Session OnCreateSession()
        {
            return new CarSession();
        }
    }
}
