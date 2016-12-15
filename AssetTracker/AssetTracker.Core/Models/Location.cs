using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
    public class Location
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string ShortName { get; set; }
        [DisplayName("Organization Branch")]
        [ForeignKey("OrganizationBranch")]
        public int OrganizationBranchId { get; set; }
        public virtual OrganizationBranch OrganizationBranch { get; set; }
        
       
       
    }
}
