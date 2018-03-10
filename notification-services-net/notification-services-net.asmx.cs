using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace notification_services_net
{
    /// <summary>
    /// Summary description for notification_services_net
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class notification_services_net : System.Web.Services.WebService
    {

        [WebMethod]
        public string ReceiveOrderResult(Guid OrderObjectId,string GSM,string MPAY,string SMSContent,double TotalPrice,double TotalUnitPrice,int State,int StatusCode,string ErrorCode,string ErrorMessage,DateTime PaymentDateTime,int GsmOperator,int GsmType,Guid SubscriberId, List<CSaleProduct> Products, int OrderChannelId,int PaymentTypeId,int PaymentCategoryId,string Pin)
        {
            return string.Empty;
        }

        [WebMethod]
        public string SubscriptionDeactivation(Guid SubscriptionId,int GSMOperator,string GSM,DateTime CreateDate,DateTime EndDate,int ProductId,string Price)
        {
            return string.Empty;
        }
    }
}
