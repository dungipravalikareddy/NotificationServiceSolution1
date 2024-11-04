using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string EmailId { get; set; }
        public string DisplayName { get; set; }
        public Guid EmploymentId { get; set; }
    }
}
