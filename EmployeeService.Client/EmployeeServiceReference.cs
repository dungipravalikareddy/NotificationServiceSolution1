using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EmployeeService.Client
{
    public class EmployeeServiceReference

    {
        private static Service1Client _service1;

        private static void BindClient()
        {
            // If service1 is already initialized, return the existing instance
            if (_service1 != null) return;


            // Read the service location from app.config
            string serviceLocation = "http://localhost/WCFService/Service1.svc";


            if (string.IsNullOrEmpty(serviceLocation))
            {
                throw new ConfigurationErrorsException("Service location URL is not defined in app.config.");
            }



            Uri serviceEndpoint = new Uri(serviceLocation);



            // Create custom binding based on the service endpoint and timeout settings

            Binding clientBinding = CreateBinding(10, serviceEndpoint);



            // Create the endpoint address
            EndpointAddress epAddress = new EndpointAddress(serviceEndpoint);


            // Initialize the service client with custom binding and endpoint
            _service1 = new Service1Client(clientBinding, epAddress);




        }
        private static Binding CreateBinding(int timeOut, Uri serviceEndpoint)
        {
            XmlDictionaryReaderQuotas rQuotas = new XmlDictionaryReaderQuotas();
            rQuotas.MaxDepth = 64;
            rQuotas.MaxStringContentLength = int.MaxValue;
            rQuotas.MaxArrayLength = int.MaxValue;
            rQuotas.MaxBytesPerRead = int.MaxValue;
            rQuotas.MaxNameTableCharCount = int.MaxValue;

            Binding clientBinding;

            if (serviceEndpoint.Scheme == Uri.UriSchemeNetTcp)
            {
                clientBinding = new NetTcpBinding(SecurityMode.None);
                ((NetTcpBinding)clientBinding).MaxReceivedMessageSize = int.MaxValue;

                // Commented out security and client credential type settings
                // ((NetTcpBinding)clientBinding).Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
                // ((NetTcpBinding)clientBinding).Security.Message.ClientCredentialType = MessageCredentialType.UserName;

                ((NetTcpBinding)clientBinding).ReaderQuotas = rQuotas;
                ((NetTcpBinding)clientBinding).TransferMode = TransferMode.Buffered;
            }
            else
            {
                clientBinding = serviceEndpoint.Scheme == Uri.UriSchemeHttp
                    ? new BasicHttpBinding(BasicHttpSecurityMode.None)
                    : new BasicHttpBinding(BasicHttpSecurityMode.Transport);

                ((BasicHttpBinding)clientBinding).UseDefaultWebProxy = false;
                ((BasicHttpBinding)clientBinding).MaxReceivedMessageSize = int.MaxValue;

                // Commented out security and client credential type settings
                // ((BasicHttpBinding)clientBinding).Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows;
                // ((BasicHttpBinding)clientBinding).Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;

                ((BasicHttpBinding)clientBinding).ReaderQuotas = rQuotas;
                ((BasicHttpBinding)clientBinding).TransferMode = TransferMode.Buffered;
            }

            clientBinding.CloseTimeout = new TimeSpan(0, 5, 0);
            clientBinding.OpenTimeout = new TimeSpan(0, 5, 0);
            clientBinding.ReceiveTimeout = new TimeSpan(0, timeOut, 0);
            clientBinding.SendTimeout = new TimeSpan(0, timeOut, 0);

            return clientBinding;
        }


        public static Employment[] CallGetEmployments()
        {
            BindClient();
            return _service1.GetEmploymentTypes();
        }

        public static User[] CallGetUsersBYEmploymentId(Schema payload)
        {
            BindClient();
            return _service1.GetUsersByEmploymentType(payload);
        }
    }

}
