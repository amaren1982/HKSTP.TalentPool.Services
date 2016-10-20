using HKSTP.TalentPool.Entities.Enumerations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;

namespace HKSTP.TalentPool.Business
{
    public class EMailTemplateManager
    {

        public static string GetSubscriptionEmailBody()
        {
            string webURL = WebConfigurationManager.AppSettings["ServerUrl"].ToString();
            var valueList = new Dictionary<string, string>();
            valueList.Add("{WEB_URL}", webURL);
            valueList.Add("{USER_FULL_NAME}", "Amarendra");


            string channelName = "Ashok" + " " + "Kumar ";
            string channelurl = webURL + "/WebPages/Login.aspx" + "?ReturnURL=" + webURL + "/WebPages/Channels/ChannelDetailsView.aspx?ID=";
            string channelLink = "<a href='" + channelurl + "'>" + channelName + "</a>";

            valueList.Add("{CELEBRITY_NAME}", channelLink);



            return BindTemplate(EMailTemplateType.Scheduled_Message, valueList);
        }


        private static string BindTemplate(EMailTemplateType templateType, Dictionary<string, string> valueList)
        {
            string emailBody = LoadContent(GetTemplatePath(templateType));
            //string emailBody = ReadTemplate(templateType);

            foreach (var item in valueList)
            {
                emailBody = emailBody.Replace(item.Key, item.Value);
            }

            return emailBody;
        }

        private static string ReadTemplate(EMailTemplateType templateType)
        {
            HttpContext httpcontext = HttpContext.Current;
            string templatePath = GetTemplatePath(templateType);
            using (StreamReader reader = new StreamReader(httpcontext.Server.MapPath(templatePath)))
            {
                return reader.ReadToEnd();
            }

        }

        public static Assembly _CurrentAssembly;

        public static Assembly CurrentAssembly
        {
            get
            {
                if (_CurrentAssembly == null)
                {
                    _CurrentAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                }

                return _CurrentAssembly;
            }
        }

        public static string LoadContent(string relativePath)
        {
            string localXMLUrl = Path.Combine(Path.GetDirectoryName(CurrentAssembly.GetName().CodeBase), relativePath);
            return File.ReadAllText(new Uri(localXMLUrl).LocalPath);
        }

        private static string GetTemplatePath(EMailTemplateType templateType)
        {
            string filePath = "";

            switch (templateType)
            {

                case EMailTemplateType.Scheduled_Message:
                    filePath = "EmailTemplates/ScheduledMessage.html";
                    break;
                case EMailTemplateType.Subscription_Message:
                    filePath = "EmailTemplates/SubscriptionMessage.html";
                    break;

            }

            return filePath;
        }
    }
}
