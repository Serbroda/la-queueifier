using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using IronOcr;

namespace la_queueifier
{
    internal class LostArk
    {
        private const string LostArkProcessName = "LOSTARK";

        public string QueueTextPrefix { get; set; }

        private ApplicationCapture applicationCapture = new ApplicationCapture();

        public LostArk(): this("Your queue number is:")
        {
            
        }

        public LostArk(string QueueTextPrefix)
        {
            this.QueueTextPrefix = QueueTextPrefix;
        }

        public Nullable<int> GetQueueNumber()
        {
            var outfile = Path.Combine(System.IO.Path.GetTempPath(), "la_" + DateTime.Now.ToString("yyyyMMddTHHmmssfff") + ".png");
            if(applicationCapture.Save(LostArkProcessName, outfile))
            {
                var queue = GetQueueNumber(outfile);
                File.Delete(outfile);
                return queue;
            }
            return null;
        }

        public Nullable<int> GetQueueNumber(string file)
        {
            Console.WriteLine("Read text from image '" + file + "'");
            var res = new IronTesseract().Read(file).Text;
            using (StringReader reader = new StringReader(res))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var queue = tryGetQueue(line);
                    if (queue.HasValue)
                    {
                        return queue;
                    }
                }
            }
            return null;
        }

        private Nullable<int> tryGetQueue(string line)
        {
            var regex = new Regex(QueueTextPrefix + @"\s?(?<queue>\d*).*");
            var match = regex.Matches(line);
            foreach (Match m in match)
            {
                return Convert.ToInt32(m.Groups["queue"].Value);
            }
            return null;
        }
    }
}
