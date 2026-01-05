namespace SmartHome.Models;

public enum DeviceType
{
	Light,
	Fan,
	AirConditioner,
	TV
}

public class SmartDevice
{
	public string Name { get; set; }
	public string Room { get; set; }
	public DeviceType Type { get; set; }
	public bool IsOn { get; set; }
}