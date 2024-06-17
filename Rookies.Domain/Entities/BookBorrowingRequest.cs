using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookies.Domain.Entities
{
    public class BookBorrowingRequest : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BookBorrowingRequestId { get; set; }

        [Required]
        public Guid RequesterId { get; set; }

        [Required]
        public DateTime RequesterDate { get; set; }

        [Required]
        public Guid? ApproverId { get; set; }

        [Required]
        public DateTime? ApproverDate { get; set; }

        [Required]
        public Guid BookId { get; set; }
        public Book Book { get; set; }
        public ICollection<BookBorrowingRequestDetail> BookBorrowingRequestDetails { get; set; }
    }
}
