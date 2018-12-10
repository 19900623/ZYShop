
import { Component, OnInit, Injector, Input, ViewChild, AfterViewInit } from '@angular/core';
import { ModalComponentBase } from '@shared/component-base/modal-component-base';
import { CreateOrUpdateArticleInput,ArticleEditDto, ArticleServiceProxy } from '@shared/service-proxies/service-proxies';
import { Validators, AbstractControl, FormControl } from '@angular/forms';

@Component({
  selector: 'create-or-edit-article',
  templateUrl: './create-or-edit-article.component.html',
  styleUrls:[
	'create-or-edit-article.component.less'
  ],
})

export class CreateOrEditArticleComponent
  extends ModalComponentBase
    implements OnInit {
    /**
    * 编辑时DTO的id
    */
    id: any ;

	  entity: ArticleEditDto=new ArticleEditDto();

    /**
    * 初始化的构造函数
    */
    constructor(
		injector: Injector,
		private _articleService: ArticleServiceProxy
	) {
		super(injector);
    }

    ngOnInit() :void{
		this.init();
    }


    /**
    * 初始化方法
    */
    init(): void {
		this._articleService.getForEdit(this.id).subscribe(result => {
			this.entity = result.article;
		});
    }

    /**
    * 保存方法,提交form表单
    */
    submitForm(): void {
		const input = new CreateOrUpdateArticleInput();
		input.article = this.entity;

		this.saving = true;

		this._articleService.createOrUpdate(input)
		.finally(() => (this.saving = false))
		.subscribe(() => {
			this.notify.success(this.l('SavedSuccessfully'));
			this.success(true);
		});
    }
}
