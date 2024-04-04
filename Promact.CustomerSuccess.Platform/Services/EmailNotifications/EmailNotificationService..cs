using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos.EmailNotifications;
using System;
using System.Net;
using System.Net.Mail;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services.EmailNotifications
{
    public class EmailNotificationService : IEmailNotificationService
    {
        private readonly IConfiguration _configuration;
        private readonly IRepository<Stakeholder,Guid> _repository;

        public EmailNotificationService(IConfiguration configuration, IRepository<Stakeholder, Guid> repository)
        {
            _configuration = configuration;
            _repository = repository;
        }
        public async Task SendNotificationAsync(string email, NotificationDataDto input)
        {
            try
            {
                var smtpSettings = _configuration.GetSection("SmtpSettings").Get<SmtpSettings>();
                // Configure the SMTP client
                using (SmtpClient smtpClient = new SmtpClient(smtpSettings.Host, smtpSettings.Port))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(smtpSettings.Username, smtpSettings.Password);
                    smtpClient.EnableSsl = true;

                    // Create the email message
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress(smtpSettings.Username);
                    mailMessage.To.Add(email); 
                    mailMessage.Subject = input.Subject; 
                    mailMessage.Body = input.Message;
                    mailMessage.IsBodyHtml = false;

                    // Send the email
                    await smtpClient.SendMailAsync(mailMessage);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to send email notification: {ex.Message}");
            }
        }
        public async Task SendNotificationAsync(List<string> emailList, NotificationDataDto input)
        {
            try
            {
                var smtpSettings = _configuration.GetSection("SmtpSettings").Get<SmtpSettings>();
                // Configure the SMTP client
                using (SmtpClient smtpClient = new SmtpClient(smtpSettings.Host, smtpSettings.Port))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(smtpSettings.Username, smtpSettings.Password);
                    smtpClient.EnableSsl = true;
                    // Create the email message
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress(smtpSettings.Username);
                    foreach (var email in emailList)
                    {
                        mailMessage.To.Add(email);
                    }
                    mailMessage.Subject = input.Subject;
                    mailMessage.Body = input.Message;
                    mailMessage.IsBodyHtml = false;

                    // Send the email
                    await smtpClient.SendMailAsync(mailMessage);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to send email notification: {ex.Message}");
            }
        }

        public async Task SandNotificationsToStakeHolders(Guid projectId, NotificationDataDto input)
        {
            var stakeholders = await _repository.GetListAsync(x => x.ProjectId == projectId);
            var emailList = stakeholders.Select(x => x.Contact).ToList();
            await SendNotificationAsync(emailList, input);
        }
    }
}
