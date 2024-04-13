using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExpenses.Domain.Models
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }
        public string? CatName { get; set; }
        public int CatOrder { get; set; }

        public virtual ICollection<SubCat> SubCats { get; set; }
    }
}
