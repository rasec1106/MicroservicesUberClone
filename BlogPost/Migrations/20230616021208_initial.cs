using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogPost.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogPosts",
                columns: table => new
                {
                    postId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    urlImages = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogPosts", x => x.postId);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    commentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    postId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.commentId);
                    table.ForeignKey(
                        name: "FK_comments_blogPosts_postId",
                        column: x => x.postId,
                        principalTable: "blogPosts",
                        principalColumn: "postId");
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    commentscommentId = table.Column<int>(type: "int", nullable: true),
                    blogPostspostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_users_blogPosts_blogPostspostId",
                        column: x => x.blogPostspostId,
                        principalTable: "blogPosts",
                        principalColumn: "postId");
                    table.ForeignKey(
                        name: "FK_users_comments_commentscommentId",
                        column: x => x.commentscommentId,
                        principalTable: "comments",
                        principalColumn: "commentId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_comments_postId",
                table: "comments",
                column: "postId");

            migrationBuilder.CreateIndex(
                name: "IX_users_blogPostspostId",
                table: "users",
                column: "blogPostspostId");

            migrationBuilder.CreateIndex(
                name: "IX_users_commentscommentId",
                table: "users",
                column: "commentscommentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "blogPosts");
        }
    }
}
