using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArkLight.Mvvm;

namespace TirePressureSensorWpfApp.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _windowTitle = "轮胎压力传感器上位机";
        public string WindowTitle
        {
            get => _windowTitle;
            set => SetProperty(ref _windowTitle, value);
        }
    }
}


