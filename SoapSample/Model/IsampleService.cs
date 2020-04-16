using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel;

namespace SoapSample.Model
{
        [ServiceContract]
        public interface ISampleService
        {
            [OperationContract]
            string Test(string s);
            [OperationContract]
            void XmlMethod(System.Xml.Linq.XElement xml);
            [OperationContract]
            MyCustomModel TestCustomModel(MyCustomModel inputModel);
        }
    }
