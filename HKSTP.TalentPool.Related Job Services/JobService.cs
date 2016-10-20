using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace HKSTP.TalentPool.Related_Job_Services
{
    public partial class JobService : ServiceBase
    {
        public JobService()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
            OnStart(null);
            OnStop();
        }

        protected override void OnStart(string[] args)
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "JobService_OnStart.txt");
        }

        protected override void OnStop()
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "JobService_OnStop.txt");
        }
    }
}
