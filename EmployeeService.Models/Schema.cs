using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService.Models
{
    [DataContract]
    public class Schema
    {
        [DataMember]
        public Guid employmentId { get; set; }
    }
}
