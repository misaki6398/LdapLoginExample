using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LdapLoginExample.Model
{
    public class EmployeeModel
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string DepartMentCode { get; set; }
        public string DepartMentName { get; set; }
        public string SubDepartMentName { get; set; }
        public string SubDepartMentCode { get; set; }
    }
}

