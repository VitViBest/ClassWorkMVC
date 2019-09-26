using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPP.DAL.Entities
{
   public class Project
    {
        public int Id { get; set; }

        [Display(Name ="Название")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        public virtual List<ProjectTeam> ProjectTeams { get; set; }

        public int? OwnerId { get; set; }

        public virtual Owner Owner { get; set; }

        [Display(Name = "Сложность")]
        public int Hard { get; set; }

        public DateTime DateEnd { get; set; }
    }
}
