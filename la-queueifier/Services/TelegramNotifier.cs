using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace la_queueifier
{
    internal class TelegramNotifier : Notifier
    {
        public string ApiToken { get; private set; }
        public string DestID { get; private set; }

        public TelegramNotifier(string ApiToken, string DestID)
        {
            this.ApiToken = ApiToken;
            this.DestID = DestID;
        }

        public void SendMessage(string message)
        {
            string urlString = $"https://api.telegram.org/bot{ApiToken}/sendMessage?chat_id={DestID}&text={message}";

            WebClient webclient = new WebClient();
            webclient.DownloadString(urlString);
        }
    }
}
