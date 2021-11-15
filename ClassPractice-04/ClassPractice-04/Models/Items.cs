using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_04.Models
{
    [Table("Products")]
    public class Items
    {
       
        public int Id { get; set; }
        
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ManufactureDate { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Brands")]
        public int BrandId { get; set; }
        
        public Brands Brands { get; set; }

    }
}
