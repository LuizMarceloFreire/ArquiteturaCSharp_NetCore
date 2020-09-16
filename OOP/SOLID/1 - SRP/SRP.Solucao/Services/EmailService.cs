using System.Net.Mail;

namespace SOLID._1___SRP.SRP.Solucao
{
    public static class EmailService
    {
        public static void Enviar(string de, string para, string assunto, string mensagem)
        {
            var mail = new MailMessage(de, para);
            var cliente = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = assunto;
            mail.Body = mensagem;
            cliente.Send(mail);
        }
    }
}
