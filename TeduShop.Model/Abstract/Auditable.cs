using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime CreatedDate { get; set; }

        string CreatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }

        string UpdatedBy { get; set; }

        string MetaKeyword { get; set; }

        string MetaDescription { get; set; }

        bool Status { get; set; }
    }

    public abstract class Auditable : IAuditable
    {
        [MaxLength(256)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        public bool Status { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}