using HKSTP.TalentPool.Business;
using HKSTP.TalentPool.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace HKSTP.TalentPool.Services
{
    partial class SubscriptionEmailNotification : ServiceBase
    {
        private System.Timers.Timer _serviceTimer;
        private bool _serviceCheckInProgress;

        public SubscriptionEmailNotification()
        {
            InitializeComponent();
            this._serviceCheckInProgress = false;
            _serviceTimer = new System.Timers.Timer();
            _serviceTimer.Elapsed += new System.Timers.ElapsedEventHandler(serviceTimer_Elapsed);
        }


        void serviceTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                if (!this._serviceCheckInProgress)
                {
                    this._serviceCheckInProgress = true;
                    this.LogMessage("Email sending Started");
                    EmailScheduler.SendEmail();
                    this.LogMessage("Email sent end");
                    this._serviceCheckInProgress = false;
                }
            }
            catch (Exception ex)
            {
                this._serviceCheckInProgress = false;
                this.LogMessage(ex.Message + Environment.NewLine + ex.StackTrace + (ex.InnerException == null ? string.Empty : ex.InnerException.Message + Environment.NewLine + ex.InnerException.StackTrace));
            }
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
            //set interval
            int interval = 60000;
            //Retrieve interval values from config file
            interval = Convert.ToInt32(ConfigurationManager.AppSettings["RunFrequency"].Trim());
            //enable timer
            this._serviceTimer.Enabled = true;
            //set timer interval
            this._serviceTimer.Interval = interval;
            //start timer
            this._serviceTimer.Start();
            //write to log
            this.LogMessage("Messenger Started.");

        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
            this._serviceTimer.Stop();
            this.LogMessage("Messenger Stopped.");
        }
          
        private void LogMessage(string message)
        {
            var loggingEnabled = Convert.ToBoolean(ConfigurationManager.AppSettings["LoggingEnabled"].Trim());
            var logFilePath = ConfigurationManager.AppSettings["EmailLogFilePath"].Trim();
            var maxLogFileSize = Convert.ToInt64(ConfigurationManager.AppSettings["MaxLogFileSize"].Trim());

            ExceptionHandler.LogMessage(message, loggingEnabled, maxLogFileSize, logFilePath);
        }
    }
}
