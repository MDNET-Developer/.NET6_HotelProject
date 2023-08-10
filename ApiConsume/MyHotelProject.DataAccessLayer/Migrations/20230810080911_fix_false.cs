using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotelProject.DataAccessLayer.Migrations
{
    public partial class fix_false : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CaregoryId",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "MessageCategoryId",
                table: "Contacts",
                newName: "MessageCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_MessageCategoryId",
                table: "Contacts",
                newName: "IX_Contacts_MessageCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryID",
                table: "Contacts",
                column: "MessageCategoryID",
                principalTable: "MessageCategories",
                principalColumn: "MessageCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryID",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "MessageCategoryID",
                table: "Contacts",
                newName: "MessageCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_MessageCategoryID",
                table: "Contacts",
                newName: "IX_Contacts_MessageCategoryId");

            migrationBuilder.AddColumn<int>(
                name: "CaregoryId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryId",
                table: "Contacts",
                column: "MessageCategoryId",
                principalTable: "MessageCategories",
                principalColumn: "MessageCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
