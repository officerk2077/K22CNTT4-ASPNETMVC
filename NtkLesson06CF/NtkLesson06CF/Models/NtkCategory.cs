using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace NtkLesson06CF.Models
{
    public class NtkCategory
    {
        [Key]
        public int NtkId { get; set; }
        public string NtkCategoryName { get; set; }

        // Thuộc tính quan hệ 
        public virtual ICollection<Ntkbook> Ntkbooks { get; set; }
    }
}