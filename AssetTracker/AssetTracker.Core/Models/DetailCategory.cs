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
    public class DetailCategory
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        [DisplayName("Sub Category")]
        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
