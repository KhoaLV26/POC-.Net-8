using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookies.Domain.Entities
{
    public class BookBorrowingRequestDetail : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BookBorrowingRequestDetailId { get; set; }

        public Guid BookBorrowingRequestId { get; set; }

        public BookBorrowingRequest BookBorrowingRequest { get; set; }
    }
}
