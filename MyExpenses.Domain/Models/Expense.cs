using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExpenses.Domain.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime TDate { get; set; }
        [MaxLength(100)]
        public string? Item { get; set; }
        [MaxLength(200)]
        public string? ItemDetails { get; set; }
        public decimal Amount { get; set; }
        public decimal ForeignAmount { get; set; }
        [MaxLength(3)]
        public string? Currency { get; set; }

        public int SubCatId { get; set; }
        [ForeignKey(nameof(SubCatId))]
        public virtual SubCat SubCat { get; set; }
    }
}
