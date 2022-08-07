using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
     public class Writer
    {
        [Key] //Id için birincil anahtar eklendi.
        public int WriterID { get; set; }

        [StringLength(50)] //Karakter uzunluğu belirleme.
        public string WriterName { get; set; }

        [StringLength(50)]
        public string WriterSurname { get; set; }

        [StringLength(250)]
        public string WriterImage { get; set; }

        [StringLength(100)]
        public string WriterAbout { get; set; }

        [StringLength(200)]
        public string WriterMail { get; set; }

        [StringLength(200)]
        public string WriterPassword { get; set; }

        [StringLength(50)]
        public string WriterTitle { get; set; }

        public ICollection<Heading> Headings { get; set; }

        public ICollection<Content> Contents { get; set; }
       
    }
}
