using Android.Content;
using AndroidX.Car.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTube_Control.Platforms.Android.Auto.Screens;

namespace YouTube_Control.Platforms.Android.Auto.Sessions
{
    public class CarSession : Session
    {
        public override Screen OnCreateScreen(Intent p0)
        {
            return new CarScreenMenu(CarContext);
        }
    }
}
