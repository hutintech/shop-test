using System;

namespace MyShop.Model.Abstract
{
    public interface IAudiable
    {
        DateTime? CreatedDateTime { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdateeBy { get; set; }

        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }

        bool Status { get; set; }
    }
}