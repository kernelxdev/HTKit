namespace HTKit;

public class UI
{
	Tools tools = new Tools();
	
	public void PrintUI()
	{
		// TODO: Add cool ASCII art.
		
		Console.Clear();

		Console.WriteLine("Hacker Toolkit");

		if (tools.CheckIsUnix())
		{
			Console.WriteLine("1. DoS attack.\n" +
			                  "2. Port probe. TODO\n" +
			                  "3. GeoLocation lookup. TODO\n" +
			                  "4. Quick VPN connection. TODO\n" +
			                  "5. GZip compression. TODO\n" +
			                  "6. Open app in a container. TODO\n" +
			                  "7. Open linux utility. TODO\n" +
			                  "\n0. Exit.\n");
		}
		else
		{
			Console.WriteLine("1. DoS attack.\n" +
			                  "2. Port probe. TODO\n" +
			                  "3. GeoLocation lookup. TODO\n" +
			                  "4. Quick VPN connection. TODO\n" +
			                  "5. GZip compression. TODO\n" +
			                  "6. Open app in a container. TODO\n" +
			                  "\n0. Exit.\n");
		}
	}

	public int SelectOption()
	{
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