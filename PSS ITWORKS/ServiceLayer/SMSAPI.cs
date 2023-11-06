using PSS_ITWORKS.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace PSS_ITWORKS.ServiceLayer
{
    internal class SMSAPI
    {
        string accountSid = Environment.GetEnvironmentVariable("TwilioSID");
        string authToken = Environment.GetEnvironmentVariable("TwilioAuthToken");
        string TwilioNumber = "+12293948850";
        public void SendSMS(string sms, string number)
        {
            if(number.Length == 10){
                string temp = number;
                number = "+27";
                number = number + temp.Substring(1,9);
            }
            else
            {
                ErrorHandler.DisplayError("The number is too short");
            }
            try
            {
                TwilioClient.Init(accountSid, authToken);

                var mediaUrl = new[] {
                new Uri("https://c1.staticflickr.com/3/2899/14341091933_1e92e62d12_b.jpg")
                }.ToList();

                var message = MessageResource.Create(
                    body: sms,
                    from: new Twilio.Types.PhoneNumber(TwilioNumber),
                    mediaUrl: mediaUrl,
                    to: new Twilio.Types.PhoneNumber(number)
                );

                Console.WriteLine(message.Sid);
                Console.ReadLine();
                ErrorHandler.DisplayError($"Sent Message\n {sms}\n To {number}");
            }
            catch
            {
                ErrorHandler.DisplayError($"Tried to send message\n {sms}\n To {number}");
                ErrorHandler.DisplayError("The phone number is Invalid");
            }
        }
    }
}


