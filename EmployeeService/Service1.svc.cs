using EmployeeService.Implementation;
using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        private readonly ServiceImplementation _service;


        public Service1()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PostgresConn"].ConnectionString;
            _service = new ServiceImplementation(connectionString);
        }
        public List<Employment> GetEmploymentTypes()
        {

            return _service.GetAllEmployements();

        }

        public List<User> GetUsersByEmploymentType(Schema payload)
        {
            return _service.GetUsersByEmploymentType(payload);
        }

    }
       
}
