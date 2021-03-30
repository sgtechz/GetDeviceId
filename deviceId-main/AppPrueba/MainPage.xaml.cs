using Plugin.DeviceInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPrueba
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var deviceId = CrossDeviceInfo.Current.Id;
            var deviceIdResult = new Label();

            deviceIdResult.Text = deviceId;

            titleDeviceId.Text = "My device Id: " + deviceIdResult.Text;
        }
    }
}
