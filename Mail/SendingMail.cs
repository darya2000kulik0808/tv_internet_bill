using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;


namespace Mail
{
    public class SendingMail
    {
        public void SendEMail (string mail_adress, int summ, string method_pay)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("413skaia@gmail.com", "Ваш провайдер");
            // кому отправляем
            MailAddress to = new MailAddress(mail_adress);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Чек";
            // текст письма
            m.Body = "<h2>Ваш платёж принят</h2>" +
                      "<p>Ваш платёж на сумму " + summ.ToString() + " рублей принят</p>" +
                      "<p>Способ оплаты: " + method_pay + "</p>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("413skaia@gmail.com", "JWyC72jngL4kka9");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

    }
}
