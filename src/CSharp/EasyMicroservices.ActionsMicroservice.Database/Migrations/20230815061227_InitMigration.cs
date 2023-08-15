using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMicroservices.ActionsMicroservice.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsLiked = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentity = table.Column<string>(type: "nvarchar(450)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Views",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueIdentity = table.Column<string>(type: "nvarchar(450)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Views", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Likes_CreationDateTime",
                table: "Likes",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_DeletedDateTime",
                table: "Likes",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_IsDeleted",
                table: "Likes",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_ModificationDateTime",
                table: "Likes",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_UniqueIdentity",
                table: "Likes",
                column: "UniqueIdentity");

            migrationBuilder.CreateIndex(
                name: "IX_Views_CreationDateTime",
                table: "Views",
                column: "CreationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Views_DeletedDateTime",
                table: "Views",
                column: "DeletedDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Views_IsDeleted",
                table: "Views",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Views_ModificationDateTime",
                table: "Views",
                column: "ModificationDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Views_UniqueIdentity",
                table: "Views",
                column: "UniqueIdentity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Views");
        }
    }
}
