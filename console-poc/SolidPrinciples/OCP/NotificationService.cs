namespace console_poc.SolidPrinciples.OCP;
public class NotificationService
{
    public void SendOTP(string medium){
        if(medium == "email"){
            //write email related logic
            //use SendGrid
            // Mailgun
            // Amazon SES
            // Twilio SendGrid API
        }
        else if(medium == "mobile"){
            // Popular SMS Providers with .NET libraries or APIs:

            // Twilio
            // Plivo
            // Nexmo
            // Amazon SNS
            //using Twilio;
            // using Twilio.Rest.Verify.V2.Service;

            // // Replace with your account credentials and recipient phone number
            // string accountSid = "YOUR_ACCOUNT_SID";
            // string authToken = "YOUR_AUTH_TOKEN";
            // string twilioNumber = "YOUR_TWILIO_NUMBER";
            // string recipientNumber = "+15551234567";

            // var client = new TwilioRestClient(accountSid, authToken);

            // var verification = VerificationResource.Create(
            //     to: recipientNumber,
            //     channel: "sms",
            //     serviceSid: "YOUR_SERVICE_SID"
            // );

            // if (verification.Status == "pending")
            // {
            //     Console.WriteLine("Verification code sent successfully!");
            // }
            // else
            // {
            //     Console.WriteLine("Error sending verification code: " + verification.ErrorMessage);
            // }
        }
        else if(medium == "whatsapp"){
            // 
        }
    }
}
