using System.Net.Mail;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegistrationNotificationChannel(new MailNotificationChannel());
            encoder.RegistrationNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());
            // 37 Interfaces and Polymorphism 
        }
    }
}
