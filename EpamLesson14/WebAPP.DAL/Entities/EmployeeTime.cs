using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPP.DAL.Entities
{
   public class EmployeeTime
    {
        public int Id { get; set; }

        public int? ProjectTeamId { get; set; }

        public virtual ProjectTeam ProjectTeam { get; set; }

        public virtual Employee Employee { get; set; }

        public int? EmployeeId { get; set; }

        public virtual DateTime DateLeave { get; set; }
    }
}
