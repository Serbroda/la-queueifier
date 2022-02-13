using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace la_queueifier
{
    public partial class MainForm : Form
    {
        private bool started = false;

        private bool hasInformed = false;
        public MainForm()
        {
            InitializeComponent();

            tbTelegramApiToken.Text = la_queueifier.Properties.Settings.Default.TelegramToken;
            tbTelegramDestinationId.Text = la_queueifier.Properties.Settings.Default.TelegramDestinationId;
            nudQueueReaches.Value = la_queueifier.Properties.Settings.Default.QueueReaches;
            tbQueuePrefix.Text = la_queueifier.Properties.Settings.Default.QueueTextPrefix;
            ExamineControlStates();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if(started)
                return;

            started = true;
            ExamineControlStates();

            la_queueifier.Properties.Settings.Default.TelegramToken = tbTelegramApiToken.Text;
            la_queueifier.Properties.Settings.Default.TelegramDestinationId = tbTelegramDestinationId.Text;
            la_queueifier.Properties.Settings.Default.QueueReaches = Convert.ToInt32(nudQueueReaches.Value);
            la_queueifier.Properties.Settings.Default.QueueTextPrefix = tbQueuePrefix.Text;
            la_queueifier.Properties.Settings.Default.Save();

            try
            {
                var progress = new Progress<string>(s => tbQueueNumber.Text = s);
                await Task.Factory.StartNew(() =>
                {
                    var apiToken = ckSendNotification.Checked ? tbTelegramApiToken.Text : null;
                    var destinationId = ckSendNotification.Checked ? tbTelegramDestinationId.Text : null;
                    StartQueueNumberUpdate(progress, tbQueuePrefix.Text, apiToken, destinationId, Convert.ToInt32(nudQueueReaches.Value));
                }, TaskCreationOptions.LongRunning);
            } 
            catch (Exception ex)
            {
                started = false;
                ExamineControlStates();
            }

        }

        private void StartQueueNumberUpdate(IProgress<string> progress, string queueTextPrefix, string apiToken, string destinationId, int queueReaches = 300)
        {
            var la = new LostArk(queueTextPrefix);
            while(started)
            {
                var queue = la.GetQueueNumber();
                if (queue.HasValue)
                {
                    progress.Report("" + la.GetQueueNumber());
                    if (!hasInformed && queue < queueReaches && apiToken != null && destinationId != null)
                    {
                        var notifier = new TelegramNotifier(apiToken, destinationId);
                        notifier.SendMessage("Lost Ark queue is " + queue.Value);
                        hasInformed = true;
                    }
                }
                else
                    progress.Report("??");

                Task.Delay(10000).Wait();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            started = false;
            ExamineControlStates();
        }

        private void ExamineControlStates()
        {
            btnStart.Enabled = !started;
            btnStop.Enabled = started;

            ckSendNotification.Enabled = !started;
            tbTelegramApiToken.ReadOnly = !ckSendNotification.Checked || started;
            tbTelegramDestinationId.ReadOnly = !ckSendNotification.Checked || started;
            nudQueueReaches.ReadOnly = !ckSendNotification.Checked || started;
            tbQueuePrefix.ReadOnly = started;
        }

        private void ckSendNotification_CheckedChanged(object sender, EventArgs e)
        {
            ExamineControlStates();
        }
    }
}
