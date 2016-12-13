using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
  public class DetailCategory
    {
      public int Id { get; set; }
      [Required]
      public int GeneralCategoryId  { get; set; }
        [Required]
      public int CategoryId { get; set; }
      [Required]
      public int SubCategoryId { get; set; }
      [Required]
      public string Code { get; set; }
      public GeneralCategory GeneralCategory { get; set; }
      public Category Category { get; set; }
      public SubCategory SubCategory { get; set; }
    }
}
