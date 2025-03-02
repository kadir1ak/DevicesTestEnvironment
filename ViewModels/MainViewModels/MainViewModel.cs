using DevicesTestEnvironment.ViewModels.DeviceViewModels;

namespace DevicesTestEnvironment.ViewModels.MainViewModels
{
    public class MainViewModel
    {
        public DevicesViewModel DevicesVM { get; set; }

        public MainViewModel()
        {
            DevicesVM = new DevicesViewModel();
        }
    }
}
