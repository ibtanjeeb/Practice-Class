using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_04.Models
{
   public class Brands
    {
        [Key]
        public int BrandId { get; set; }
        
        public string BrandName { get; set; }

        public ICollection<Items> Items { get; set; }


    }
}
