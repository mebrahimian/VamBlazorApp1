using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading.Tasks;

public class EmailService
{
    private readonly IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task SendEmailAsync(string toEmail, string subject, string body)
    {
        var mailConfig = _configuration.GetSection("MailConfiguration");
        var fromEmail = mailConfig["From"];
        var smtpHost = mailConfig["Host"];
        var smtpPort = int.Parse(mailConfig["Port"]);
        var smtpUserName = mailConfig["UserName"];
        var smtpPassword = mailConfig["Password"];
        var displayName = mailConfig["DisplayName"];

        var message = new MailMessage
        {
            From = new MailAddress(fromEmail, displayName),
            Subject = subject,
            Body = body,
            IsBodyHtml = true
        };

        message.To.Add(new MailAddress(toEmail));
    }
}
