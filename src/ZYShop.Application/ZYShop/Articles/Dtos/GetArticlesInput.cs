
using Abp.Runtime.Validation;
using ZYShop.Dtos;
using ZYShop.ZYShop.Articles;

namespace ZYShop.ZYShop.Articles.Dtos
{
    public class GetArticlesInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
