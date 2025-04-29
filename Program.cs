namespace HTKit;

internal class Program
{
	private static void Main(string[] args)
	{
		UI ui = new UI();

		bool enabled = true;
		
		while (enabled)
		{
			ui.PrintUI();

			switch (ui.SelectOption())
			{
				case 1:
					Console.WriteLine("Super dos tool :o");

					Console.WriteLine("Press any key to continue...");
					Console.ReadKey();
					break;
				
				default:
					Console.WriteLine("Selection option 1-8!");
					break;
				case 8:
					enabled = false;
					break;
				case 0:
					Console.WriteLine("Encountered an error!");
					enabled = false;
					break;
			}
		}

		Console.WriteLine("\nExiting press any key to continue...");
		Console.ReadKey();
	}
}