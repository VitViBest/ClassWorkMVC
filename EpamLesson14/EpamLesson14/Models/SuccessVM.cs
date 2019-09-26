using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPP.DAL.Entities;

namespace EpamLesson14.Models
{
    public class SuccessVM
    {
        public List<EmployeeTime> Employees { get; set; }

        public DateTime End { get; set; }
    }
}