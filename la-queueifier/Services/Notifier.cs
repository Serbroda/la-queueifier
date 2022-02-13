using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_queueifier
{
    internal interface Notifier
    {
        void SendMessage(string message);
    }
}
