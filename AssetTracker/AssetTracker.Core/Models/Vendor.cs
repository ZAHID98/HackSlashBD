using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace AssetTracker.Core.Models
{
   public  class Vendor
    {
        public int  Id { get; set; }
         [Required]
        public string  Name { get; set; }
        [Required]
        [Phone]
        public string PhoneNuber { get; set; }
         [EmailAddress]
        public string EmailAddress { get; set; }
       [Required]
        public string Address { get; set; }
    }
}
