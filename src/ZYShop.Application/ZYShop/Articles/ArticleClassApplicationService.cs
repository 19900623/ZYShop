
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
using Abp.Extensions;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;


using ZYShop.ZYShop.Articles;
using ZYShop.ZYShop.Articles.Dtos;
using ZYShop.ZYShop.Articles.DomainService;
using ZYShop.ZYShop.Articles.Authorization;


namespace ZYShop.ZYShop.Articles
{
    /// <summary>
    /// ArticleClass应用层服务的接口实现方法  
    ///</summary>
    [AbpAuthorize]
    public class ArticleClassAppService : ZYShopAppServiceBase, IArticleClassAppService
    {
        private readonly IRepository<ArticleClass, int> _entityRepository;

        private readonly IArticleClassManager _entityManager;

        /// <summary>
        /// 构造函数 
        ///</summary>
        public ArticleClassAppService(
        IRepository<ArticleClass, int> entityRepository
        ,IArticleClassManager entityManager
        )
        {
            _entityRepository = entityRepository; 
             _entityManager=entityManager;
        }


        /// <summary>
        /// 获取ArticleClass的分页列表信息
        ///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
		[AbpAuthorize(ArticleClassPermissions.Query)] 
        public async Task<PagedResultDto<ArticleClassListDto>> GetPaged(GetArticleClasssInput input)
		{

		    var query = _entityRepository.GetAll();
			// TODO:根据传入的参数添加过滤条件
            

			var count = await query.CountAsync();

			var entityList = await query
					.OrderBy(input.Sorting).AsNoTracking()
					.PageBy(input)
					.ToListAsync();

			// var entityListDtos = ObjectMapper.Map<List<ArticleClassListDto>>(entityList);
			var entityListDtos =entityList.MapTo<List<ArticleClassListDto>>();

			return new PagedResultDto<ArticleClassListDto>(count,entityListDtos);
		}


		/// <summary>
		/// 通过指定id获取ArticleClassListDto信息
		/// </summary>
		[AbpAuthorize(ArticleClassPermissions.Query)] 
		public async Task<ArticleClassListDto> GetById(EntityDto<int> input)
		{
			var entity = await _entityRepository.GetAsync(input.Id);

		    return entity.MapTo<ArticleClassListDto>();
		}

		/// <summary>
		/// 获取编辑 ArticleClass
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(ArticleClassPermissions.Create,ArticleClassPermissions.Edit)]
		public async Task<GetArticleClassForEditOutput> GetForEdit(NullableIdDto<int> input)
		{
			var output = new GetArticleClassForEditOutput();
ArticleClassEditDto editDto;

			if (input.Id.HasValue)
			{
				var entity = await _entityRepository.GetAsync(input.Id.Value);

				editDto = entity.MapTo<ArticleClassEditDto>();

				//articleClassEditDto = ObjectMapper.Map<List<articleClassEditDto>>(entity);
			}
			else
			{
				editDto = new ArticleClassEditDto();
			}

			output.ArticleClass = editDto;
			return output;
		}


		/// <summary>
		/// 添加或者修改ArticleClass的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(ArticleClassPermissions.Create,ArticleClassPermissions.Edit)]
		public async Task CreateOrUpdate(CreateOrUpdateArticleClassInput input)
		{

			if (input.ArticleClass.Id.HasValue)
			{
				await Update(input.ArticleClass);
			}
			else
			{
				await Create(input.ArticleClass);
			}
		}


		/// <summary>
		/// 新增ArticleClass
		/// </summary>
		[AbpAuthorize(ArticleClassPermissions.Create)]
		protected virtual async Task<ArticleClassEditDto> Create(ArticleClassEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增

            // var entity = ObjectMapper.Map <ArticleClass>(input);
            var entity=input.MapTo<ArticleClass>();
			

			entity = await _entityRepository.InsertAsync(entity);
			return entity.MapTo<ArticleClassEditDto>();
		}

		/// <summary>
		/// 编辑ArticleClass
		/// </summary>
		[AbpAuthorize(ArticleClassPermissions.Edit)]
		protected virtual async Task Update(ArticleClassEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新

			var entity = await _entityRepository.GetAsync(input.Id.Value);
			input.MapTo(entity);

			// ObjectMapper.Map(input, entity);
		    await _entityRepository.UpdateAsync(entity);
		}



		/// <summary>
		/// 删除ArticleClass信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(ArticleClassPermissions.Delete)]
		public async Task Delete(EntityDto<int> input)
		{
			//TODO:删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(input.Id);
		}



		/// <summary>
		/// 批量删除ArticleClass的方法
		/// </summary>
		[AbpAuthorize(ArticleClassPermissions.BatchDelete)]
		public async Task BatchDelete(List<int> input)
		{
			// TODO:批量删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(s => input.Contains(s.Id));
		}


		/// <summary>
		/// 导出ArticleClass为excel表,等待开发。
		/// </summary>
		/// <returns></returns>
		//public async Task<FileDto> GetToExcel()
		//{
		//	var users = await UserManager.Users.ToListAsync();
		//	var userListDtos = ObjectMapper.Map<List<UserListDto>>(users);
		//	await FillRoleNames(userListDtos);
		//	return _userListExcelExporter.ExportToFile(userListDtos);
		//}

    }
}


