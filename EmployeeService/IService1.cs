using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeService
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Employment> GetEmploymentTypes();

        [OperationContract]
        List<User> GetUsersByEmploymentType(Schema payload);

    }
}
