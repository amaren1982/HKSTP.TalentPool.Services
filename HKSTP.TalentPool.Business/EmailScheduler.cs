using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HKSTP.TalentPool.Entities;


namespace HKSTP.TalentPool.Business
{
    public class EmailScheduler
    {
        
        public static void SendEmail()
        {

            var emailBody = EMailTemplateManager.GetSubscriptionEmailBody();
            EMailManager emailer = new EMailManager();
            emailer.MailTo = "amaren1982@gmail.com";
            emailer.Subject = "Test Email";
            emailer.MailBody = emailBody;
            emailer.SendMail();
        }

        public static void SendSubscriptionEmail()
        {
            TalentPoolEntities poolEntities = new TalentPoolEntities();
           // List<TB_JOB_SEEKER> jobSeeker= poolEntities.TB_JOB_SEEKER
        }
    }
}
