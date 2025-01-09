using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eindopdracht_CSharp.Migrations
{
    /// <inheritdoc />
    public partial class MakeCategoryIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Categories_CategoryId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Enclosures_EnclosureId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Enclosures_Zoos_ZooId",
                table: "Enclosures");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Enclosures",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animals",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "EnclosureId",
                table: "Animals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Animals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Enclosures_Id_Name",
                table: "Enclosures",
                columns: new[] { "Id", "Name" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Categories_CategoryId",
                table: "Animals",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Enclosures_EnclosureId",
                table: "Animals",
                column: "EnclosureId",
                principalTable: "Enclosures",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Enclosures_Zoos_ZooId",
                table: "Enclosures",
                column: "ZooId",
                principalTable: "Zoos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Categories_CategoryId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Enclosures_EnclosureId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Enclosures_Zoos_ZooId",
                table: "Enclosures");

            migrationBuilder.DropIndex(
                name: "IX_Enclosures_Id_Name",
                table: "Enclosures");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Enclosures",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "EnclosureId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Categories_CategoryId",
                table: "Animals",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Enclosures_EnclosureId",
                table: "Animals",
                column: "EnclosureId",
                principalTable: "Enclosures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enclosures_Zoos_ZooId",
                table: "Enclosures",
                column: "ZooId",
                principalTable: "Zoos",
                principalColumn: "Id");
        }
    }
}
