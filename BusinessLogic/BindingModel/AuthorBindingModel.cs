using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogic.BindingModel
{
    public class AuthorBindingModel
    {
        public int? Id { get; set; }
        public int ArticleId { get; set; }
        public string FIO { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string Work { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
