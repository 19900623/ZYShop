using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZYShop.Migrations
{
    public partial class addArticleManageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ZY");

            migrationBuilder.CreateTable(
                name: "ArticleClasss",
                schema: "ZY",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    FatherId = table.Column<int>(maxLength: 65, nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    ClassName = table.Column<string>(maxLength: 65, nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    IsSystem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleClasss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                schema: "ZY",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 65, nullable: false),
                    ClassId = table.Column<string>(maxLength: 65, nullable: false),
                    IsTop = table.Column<int>(maxLength: 65, nullable: false),
                    Author = table.Column<string>(maxLength: 128, nullable: true),
                    Resource = table.Column<string>(maxLength: 128, nullable: true),
                    Keywords = table.Column<string>(maxLength: 128, nullable: true),
                    Url = table.Column<string>(maxLength: 256, nullable: true),
                    Photo = table.Column<string>(maxLength: 256, nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleClasss",
                schema: "ZY");

            migrationBuilder.DropTable(
                name: "Articles",
                schema: "ZY");
        }
    }
}
