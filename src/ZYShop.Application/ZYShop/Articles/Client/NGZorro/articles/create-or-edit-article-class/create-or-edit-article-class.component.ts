
import { Component, OnInit, Injector, Input, ViewChild, AfterViewInit } from '@angular/core';
import { ModalComponentBase } from '@shared/component-base/modal-component-base';
import { CreateOrUpdateArticleClassInput,ArticleClassEditDto, ArticleClassServiceProxy } from '@shared/service-proxies/service-proxies';
import { Validators, AbstractControl, FormControl } from '@angular/forms';

@Component({
  selector: 'create-or-edit-article-class',
  templateUrl: './create-or-edit-article-class.component.html',
  styleUrls:[
	'create-or-edit-article-class.component.less'
  ],
})

export class CreateOrEditArticleClassComponent
  extends ModalComponentBase
    implements OnInit {
    /**
    * 编辑时DTO的id
    */
    id: any ;

	  entity: ArticleClassEditDto=new ArticleClassEditDto();

    /**
    * 初始化的构造函数
    */
    constructor(
		injector: Injector,
		private _articleClassService: ArticleClassServiceProxy
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
		this._articleClassService.getForEdit(this.id).subscribe(result => {
			this.entity = result.articleClass;
		});
    }

    /**
    * 保存方法,提交form表单
    */
    submitForm(): void {
		const input = new CreateOrUpdateArticleClassInput();
		input.articleClass = this.entity;

		this.saving = true;

		this._articleClassService.createOrUpdate(input)
		.finally(() => (this.saving = false))
		.subscribe(() => {
			this.notify.success(this.l('SavedSuccessfully'));
			this.success(true);
		});
    }
}
