using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExpenses.Domain.Models
{
    public class SubCat
    {
        public int SubCatId { get; set; }
        [MaxLength(50)]
        public string? SubCatName { get; set; }
        public int SubCatOrder { get; set; }

        public int CatId { get; set; }

        [ForeignKey("CatId")]
        public virtual Category Category { get; set; }
    }
}
