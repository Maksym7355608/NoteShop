using NoteShop.BLL.Interfaces;
using NoteShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.Json;

namespace NoteShop.BLL.Business_Logic
{
    public class EmailSender : ISender
    {
        private struct Sender
        {
            public string Email { get; }
            public string Password { get; }
        }

        private string subject;
        private string text;

        public async void SendInformationMessage(Order order)
        {
            subject = $"Your order {order.Id} is successfuly formalized";
            text = "Thank you for making order on our site. Waiting, administrator will phone you soon!";

            using FileStream fs = new FileStream("wwwroot/json/sender.json", FileMode.Open, FileAccess.Read);

            var x = await JsonSerializer.DeserializeAsync<Sender>(fs);

            SmtpClient client = new SmtpClient("smpt.gmail.com", 465)
            {
                Credentials = new NetworkCredential(x.Email, x.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };

            MailMessage message = new MailMessage(x.Email, order.Email)
            {
                Subject = subject,
                Body = text
            };

            try
            {
                await client.SendMailAsync(message);
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
