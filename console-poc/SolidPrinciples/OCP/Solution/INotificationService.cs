namespace console_poc.SolidPrinciples.OCP.Solution;
public interface INotificationService
{
    public void SendOTP(string medium);
    public string SendTransactionStatus(string medium);
}
