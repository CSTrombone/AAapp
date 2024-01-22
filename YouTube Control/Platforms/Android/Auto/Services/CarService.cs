using Android.App;
using AndroidX.Car.App;
using AndroidX.Car.App.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTube_Control.Platforms.Android.Auto.Sessions;

namespace YouTube_Control.Platforms.Android.Auto.Services
{
    [Service(Exported = true)]
    [IntentFilter(new string[] { "androidX.Car.App.CarAppService" }, Categories = new[] { "androidx.car.app.category.POI" })]
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
