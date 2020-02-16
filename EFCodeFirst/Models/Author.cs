using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirst.Models
{    
    public class Author
    {        
        [Key]
        public int AuthorId { get; set; }       
        [Required]
        public string Name { get; set; }
        [Required]
        public string MailId { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
