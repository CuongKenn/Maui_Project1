using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SmartHome.Models;

namespace SmartHome.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    [ObservableProperty] private int activeDevices = 5;
    [ObservableProperty] private int efficiency = 92;
    [ObservableProperty] private int familyMembers = 3;

    public ObservableCollection<SmartDevice> Devices { get; } = new();

    public HomeViewModel()
    {
        Devices.Add(new SmartDevice { Name = "Ceiling Fan", Room = "Living Room", Type = DeviceType.Fan });
        Devices.Add(new SmartDevice { Name = "Air Conditioner", Room = "Bedroom", Type = DeviceType.AirConditioner });
        Devices.Add(new SmartDevice { Name = "Smart TV", Room = "Living Room", Type = DeviceType.TV });
        Devices.Add(new SmartDevice { Name = "RGB Lights", Room = "Kitchen", Type = DeviceType.Light });
        Devices.Add(new SmartDevice { Name = "Table Fan", Room = "Study Room", Type = DeviceType.Fan });
        Devices.Add(new SmartDevice { Name = "Pendant Lights", Room = "Dining Room", Type = DeviceType.Light });
        Devices.Add(new SmartDevice { Name = "Split AC", Room = "Master Bedroom", Type = DeviceType.AirConditioner });
        Devices.Add(new SmartDevice { Name = "TV", Room = "Bedroom", Type = DeviceType.TV });
    }

    [RelayCommand]
    private void AllOn()
    {
        foreach (var device in Devices)
            device.IsOn = true;
    }

    [RelayCommand]
    private void NightMode()
    {
        foreach (var device in Devices)
            device.IsOn = false;
    }
}
