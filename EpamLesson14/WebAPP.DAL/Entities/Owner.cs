using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPP.DAL.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Номер")]
        public string Number { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
