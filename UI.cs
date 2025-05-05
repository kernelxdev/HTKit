namespace HTKit;

public class UI
{
	Tools tools = new Tools();
	
	public void PrintUI()
	{
		// TODO: Add cool ASCII art.
		
		string menu = "1. DoS attack.\n" +
		              "2. Port probe. TODO\n" +
		              "3. GeoLocation lookup. TODO\n" +
		              "4. Quick VPN connection. TODO\n" +
		              "5. GZip compression. TODO\n" +
		              "6. Open app in a container. TODO\n";
		
		Console.Clear();
		Console.WriteLine("Hacker Toolkit");
		if (tools.CheckIsUnix()) menu += "7. Open linux utility. TODO\n";

		menu += "\n0. Exit.\n";

		Console.WriteLine(menu);
	}

	public int SelectOption(bool write, string menu)
	{
		if(write)
			Console.WriteLine($"{menu}\n");
		
		try
		{
			return int.Parse(Console.ReadLine());
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);

			return 69;
		}
	}
}