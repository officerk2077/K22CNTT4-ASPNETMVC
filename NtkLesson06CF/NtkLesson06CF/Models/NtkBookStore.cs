using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NtkLesson06CF.Models
{
    public class NtkBookStore:DbContext
    {
        public NtkBookStore() : base { } 

        //Khai báo các thuộc tính tương ứng với các bảng trong cơ sở dữ liệu
        public DbSet<NtkCategory>  NtkCategories { get; set; }
        public DbSet<Ntkbook> Ntkbooks { get; set; }
    }
}