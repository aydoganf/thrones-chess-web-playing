namespace WebChessPlaying.Configuration
{
    public interface IAppConfiguration
    {
        string SocketUrl { get; }
        string APIBaseUrl { get; }

        void Configure(string socketUrl, string apiBaseUrl);
    }
}
