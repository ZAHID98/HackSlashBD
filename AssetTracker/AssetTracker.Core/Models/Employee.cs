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
    public class Employee
    {
        public int  Id { get; set; }
        [Required]
        public string  Name { get; set; }
        public string Designation { get; set; }
        [MaxLength(11)]
        [Required]
        public string ContractNo { get; set; }
        public string  Email { get; set; }
        [DisplayName ("Organizaion Branch")]
        [ForeignKey("OrganizationBranch")]
        public int OrganizationBranchId { get; set; }
        
        public virtual OrganizationBranch OrganizationBranch { get; set;}
    }
}
