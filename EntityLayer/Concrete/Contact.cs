using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
     public class Contact
    {
        [Key] //Id için birincil anahtar eklendi.
        public int ContactID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserMail { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }

        //Burayı boş bıraktık. Bakalım boş bırakınca karşımıza nasıl gelicek.
        public string Message { get; set; }
    }
}
