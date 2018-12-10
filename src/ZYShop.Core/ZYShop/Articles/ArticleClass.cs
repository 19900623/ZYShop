using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZYShop.ZYShop.Articles
{
    public class ArticleClass: FullAuditedEntity<int>
    {
        [DefaultValue(0)]
        public int FatherId { get; set; }

        [DefaultValue(0)]
        public int OrderId { get; set; }

        [Required]
        [MaxLength(ZYShopConsts.MaxLength64)]
        public string ClassName { get; set; }

        public string Description { get; set; }

        [DefaultValue(0)]
        public int IsSystem { get; set; }
    }
}
