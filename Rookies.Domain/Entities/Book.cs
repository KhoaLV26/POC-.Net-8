using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookies.Domain.Entities
{
    public class Book : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BookId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime? PublicationDate { get; set; }

        [Required]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<BookBorrowingRequest> BookBorrowingRequests { get; set; }
    }
}
