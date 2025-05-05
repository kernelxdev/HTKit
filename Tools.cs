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
		              "3. TCP flood\n" +
		              "0. Exit";
		
		switch (ui.SelectOption(true, menu))
		{
			case 1:
				Console.WriteLine("Enter URL/IP | Time");
				string url = Console.ReadLine();
				int time =  int.Parse(Console.ReadLine());

				dosHelper.StartHTTPFlood(url, time);
				break;
			case 2:
				break;
			case 3:	
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