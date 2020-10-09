using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFinanceInvest.Data.Context.Migrations
{
    public partial class Update_Estrutura_Banco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Banco",
                table: "Banco");

            migrationBuilder.RenameTable(
                name: "Banco",
                newName: "MI_BANCO");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "MI_BANCO",
                type: "varchar",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "MI_BANCO",
                type: "varchar",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MI_BANCO",
                table: "MI_BANCO",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MI_BANCO",
                table: "MI_BANCO");

            migrationBuilder.RenameTable(
                name: "MI_BANCO",
                newName: "Banco");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Banco",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Banco",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 15);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Banco",
                table: "Banco",
                column: "Id");
        }
    }
}
