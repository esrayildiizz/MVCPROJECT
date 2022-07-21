using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
     public class Category
    {
        //Key ve StringLength burada belirtmemiz solid prensiplerini çiğnediğimiz anlamına gelir.ve bu yüzden validation'a ihtiyaç duyarız.

        [Key] //Id için birincil anahtar eklendi. 
        public int CategoryID { get; set; }

        [StringLength(50)] //Karakter uzunluğu belirleme.
        public string CategoryName { get; set; }

        [StringLength(200)]
        public string CategoryDescription { get; set; }

       
        public bool CategoryStatus { get; set; }


        public ICollection<Heading> Headings { get; set; }
    }
}
