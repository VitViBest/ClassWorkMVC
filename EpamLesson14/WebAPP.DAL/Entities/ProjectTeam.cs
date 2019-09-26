using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPP.DAL.Entities
{
    public class ProjectTeam
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }

        public virtual ICollection<EmployeeTime> EmployeeTimes { get; set; }
    }
}
