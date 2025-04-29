namespace HTKit;

public class UI
{
	// 0 Main menu | 1 In function | 2 Settings
	private int currentMenuState;

	public void PrintUI()
	{
		// TODO: Add cool ASCII art.

		currentMenuState = 0;
		
		Console.Clear();

		Console.WriteLine("Hacker Toolkit");

		Console.WriteLine("1. DoS attack.\n" +
		                  "2. Port probe. TODO\n" +
		                  "3. GeoLocation lookup. TODO\n" +
		                  "4. Quick VPN connection. TODO\n" +
		                  "5. GZip compression. TODO\n" +
		                  "6. Open app in a container. TODO\n" +
		                  "7. Open linux utility. TODO\n" +
		                  "\n8. Exit.\n");
	}

	public int SelectOption()
	{
		try
		{
			return int.Parse(Console.ReadLine());
			currentMenuState = 1;
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);

			return 0;
		}
	}
}