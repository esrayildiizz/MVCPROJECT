using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }

        [StringLength(50)] //Karakter uzunluğu belirleme.
        public string SenderMail { get; set; } //Gönderici

        [StringLength(50)] //Karakter uzunluğu belirleme.
        public string ReceiverMail { get; set; } //Alıcı

        [StringLength(100)] //Karakter uzunluğu belirleme.
        public string Subject { get; set; }

        public string MessageContact { get; set; }

        public DateTime MessageDate { get; set; }
    }
}