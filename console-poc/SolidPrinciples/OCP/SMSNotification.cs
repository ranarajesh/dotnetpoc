using console_poc.SolidPrinciples.OCP.Solution;

namespace console_poc;
public class SMSNotification : INotificationService
{
    public void SendOTP(string medium)
    {
        // Sms notification
    }

    public string SendTransactionStatus(string medium)
    {
        return null;
    }
}
