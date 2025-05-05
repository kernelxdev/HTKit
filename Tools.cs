using System.Runtime.InteropServices;
using HTKit.Helpers;

namespace HTKit;

public class Tools
{
	public void DosAttack(UI ui)
	{
		DosHelper dosHelper = new DosHelper();
		
		Console.Clear();
		string menu = "Select attack type\n" +
		              "1. HTTP flood\n" +
		              "2. UDP flood\n" +
		              "0. Exit";
		
		switch (ui.SelectOption(true, menu))
		{
			case 1:
				Console.WriteLine("Enter URL/IP");
				string httpUrl = Console.ReadLine();
				Console.WriteLine("Enter Duration (in seconds)");
				int httpTime =  int.Parse(Console.ReadLine());

				dosHelper.StartHTTPFlood(httpUrl, httpTime);
				break;
			case 2:
				Console.WriteLine("Enter IP");
				string udpIp = Console.ReadLine();	
				Console.WriteLine("Enter Port");
				int udpPort = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter Duration (in seconds)");
				int udpTime = int.Parse(Console.ReadLine());
				
				dosHelper.StartUDPFlood(udpIp, udpPort, udpTime);
				break;
			
			default:
				Console.WriteLine("Selection option 1-8!");
				break;
			case 0:
				break;
			case 69:
				Console.WriteLine("Encountered an error!");
				break;
		}
	}

	public void PortProbe()
	{
		
	}

	public void GeoLocationLookup()
	{
		
	}

	public void QuickVPNConnection()
	{
		
	}

	public void GZipCompression()
	{
		
	}

	public void ContainerizeApp()
	{
		
	}

	public void OpenLinutil()
	{
		
	}

	public bool CheckIsUnix()
	{
		return !RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
	}
}