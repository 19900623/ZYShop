(function () {
    $(function () {
        var _articleClassService = abp.services.app.articleclass;
        var _$model = $('#ArticleClassCreateModal');
        var _$form = _$model.find('form');

        // 表单验证
        _$form.validate({
            rules: {

            }
        });

        // 刷新列表
        $('#RefreshButton').click(function () {
            refreshArticleClassList();
        });

        // 删除文章分类
        $('.delete-articleClass').click(function () {
            var articleClassId = $(this).attr('data-articleClass-id');
            var articleClassName = $(this).attr('data-articleClass-className');

            deleteArticleClass(articleClassId, articleClassName);
        });

        $('.edit-articleClass').click(function (e) {
            var arvicleClassId = $(this).attr('data-articleClass-id');

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'ArticleClass/EditArticleClass?articleClassId=' + articleClassId,
                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#ArticleClassEditModal div.modal-content').html(content);
                },
                error: function (e) {

                }
            });
        });


        function refreshArticleClassList() {
            location.reload(true);
        }

        function deleteArticleClass(articleClassId, articleClassName) {
            abp.message.confirm(
                abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'ZYShop'), articleClassName),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _articleClassService.deleteArticleClass({
                            id: articleClassId
                        }).done(function () {
                            refreshArticleClassList();
                        });
                    }
                }
            );
        }

    });
});