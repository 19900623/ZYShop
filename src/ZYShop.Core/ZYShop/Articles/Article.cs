using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZYShop.ZYShop.Articles
{
    public class Article:FullAuditedEntity<int>
    {
        [Required]
        [MaxLength(ZYShopConsts.MaxLength256)]
        public string Title { get; set; }

        [Required]
        public string ClassId { get; set; }

        [DefaultValue(0)]
        public int IsTop { get; set; }

        public string Author { get; set; }

        public string Resource { get; set; }

        public string Keywords { get; set; }

        public string Url { get; set; }

        public string Photo { get; set; }

        public string Summary { get; set; }

        public string Content { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
