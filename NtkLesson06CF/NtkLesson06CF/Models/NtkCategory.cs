using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NtkLesson06CF.Models
{
    public class NtkCategory
    {
        public int NtkId { get; set; }
        public string NtkCategoryName { get; set; }

        // Thuộc tính quan hệ 
        public virtual ICollection<Ntkbook> Ntkbooks { get; set; }
    }
}