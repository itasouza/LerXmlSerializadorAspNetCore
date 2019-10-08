using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.GravacaoXML.Migrations
{
    public partial class AjusteBanco2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Especificacao",
                table: "CLASSENICE",
                type: "varchar(300)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Especificacao",
                table: "CLASSENICE",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldNullable: true);
        }
    }
}
