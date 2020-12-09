namespace WebChessPlaying.Configuration
{
    public class AppConfiguration : IAppConfiguration
    {
        public string SocketUrl { get; private set; }

        public string APIBaseUrl { get; private set; }

        public void Configure(string socketUrl, string apiBaseUrl)
        {
            SocketUrl = socketUrl;
            APIBaseUrl = apiBaseUrl;
        }
    }
}
