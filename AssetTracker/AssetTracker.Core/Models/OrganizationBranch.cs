using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
    public class OrganizationBranch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        [Display(Name = "Oraganization")]
        [ForeignKey("Organization")]
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
        [DisplayName("Employee")]
        [ForeignKey("Employees")]
        public int EmployeeId { get; set; }
        public ICollection<Employee> Employees { get; set; }
       
    }
}
