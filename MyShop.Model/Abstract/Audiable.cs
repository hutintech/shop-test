using System;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Model.Abstract
{
    public abstract class Audiable : IAudiable
    {
        public DateTime? CreatedDateTime { get; set; }
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(256)]
        public string UpdateeBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}