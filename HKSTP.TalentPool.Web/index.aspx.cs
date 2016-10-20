using HKSTP.TalentPool.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HKSTP.TalentPool.Web
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SendMessageEmail();
        }

        private static void SendMessageEmail()
        {
            var emailBody = EMailTemplateManager.GetSubscriptionEmailBody();
            EMailManager emailer = new EMailManager();
            emailer.MailTo = "amaren1982@gmail.com";
            emailer.Subject = "Test Email";
            emailer.MailBody = emailBody;
            emailer.SendMail();
        }
    }
}