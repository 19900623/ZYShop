
using System;
using System.Data;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Abp.UI;
using Abp.AutoMapper;
using Abp.Authorization;
using Abp.Linq.Extensions;
using Abp.Domain.Repositories;
using Abp.Application.Services;
using Abp.Application.Services.Dto;


using ZYShop.ZYShop.Articles.Dtos;
using ZYShop.ZYShop.Articles;

namespace ZYShop.ZYShop.Articles
{
    /// <summary>
    /// ArticleClass应用层服务的接口方法
    ///</summary>
    public interface IArticleClassAppService : IApplicationService
    {
        /// <summary>
		/// 获取ArticleClass的分页列表信息
		///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<ArticleClassListDto>> GetPaged(GetArticleClasssInput input);


		/// <summary>
		/// 通过指定id获取ArticleClassListDto信息
		/// </summary>
		Task<ArticleClassListDto> GetById(EntityDto<int> input);


        /// <summary>
        /// 返回实体的EditDto
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetArticleClassForEditOutput> GetForEdit(NullableIdDto<int> input);


        /// <summary>
        /// 添加或者修改ArticleClass的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdate(CreateOrUpdateArticleClassInput input);


        /// <summary>
        /// 删除ArticleClass信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(EntityDto<int> input);


        /// <summary>
        /// 批量删除ArticleClass
        /// </summary>
        Task BatchDelete(List<int> input);


		/// <summary>
        /// 导出ArticleClass为excel表
        /// </summary>
        /// <returns></returns>
		//Task<FileDto> GetToExcel();

    }
}
