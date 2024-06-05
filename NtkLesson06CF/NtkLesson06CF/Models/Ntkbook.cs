using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NtkLesson06CF.Models
{
    public class Ntkbook
    {
        public int NtkId    { get; set; }
        public string NtkTitle  { get; set; }
        public string NtkAuthor { get; set; }
        public int NtkYear { get; set; }
        public string NtkPublisher { get; set; }
        public string NtkPicture { get; set; }
        public int NtkCategoryId { get; set; }
        // Thuộc tính quan hệ 
        public virtual NtkCategory NtkCategory { get; set; }

    }
}