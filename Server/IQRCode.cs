namespace PingFederateQRCode.Server
{
    public interface IQRCode
    {
        Task ShowTime(DateTime currentTime);
    }
}
