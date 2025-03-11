using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Contractors.Contracts.Models
{
    public class AuditModel
    {
        [Key]
        public int Id { get; set; }
        [Precision(3)]
        public DateTime CreatedDate { get; set; }
        [Precision(3)]
        public DateTime? LastModifiedDate { get; set; }
    }
}
