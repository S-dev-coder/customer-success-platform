using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Mail;

namespace Promact.CustomerSuccess.Platform
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationController : ControllerBase
    {
        [HttpPost]
        public IActionResult SendNotification([FromBody] NotificationData notificationData)
        {
            try
            {
                // Configure the SMTP client
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential("sk7137389@gmail.com", "ehfpholzeqsejjve");
                    smtpClient.EnableSsl = true;

                    // Create the email message
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress("sk7137389@gmail.com");
                    mailMessage.To.Add(notificationData.Email);
                    mailMessage.Subject = notificationData.Subject;
                    mailMessage.Body = notificationData.Message;
                    mailMessage.IsBodyHtml = false;

                    // Send the email
                    smtpClient.Send(mailMessage);
                }
               
                // Return JSON response
                return Ok(new { Message = "Email notification sent successfully" });
            }
            catch (Exception ex)
            {
                // Return JSON response with error
                return StatusCode(500, new { ErrorMessage = $"Failed to send email notification: {ex.Message}" });
            }
        }
    }

    public class NotificationData
    {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
