using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.GravacaoXML.Migrations
{
    public partial class CreateSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "REVISTA",
                columns: table => new
                {
                    RevistaId = table.Column<string>(type: "char(32)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REVISTA", x => x.RevistaId);
                });

            migrationBuilder.CreateTable(
                name: "PROCESSO",
                columns: table => new
                {
                    ProcessoId = table.Column<string>(type: "char(32)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: true),
                    DataDoDeposito = table.Column<DateTime>(type: "DateTime", nullable: true),
                    RevistaId = table.Column<string>(type: "char(32)", nullable: false),
                    Apostila = table.Column<string>(type: "varchar(8000)", nullable: true),
                    Procurador = table.Column<string>(type: "varchar(8000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROCESSO", x => x.ProcessoId);
                    table.ForeignKey(
                        name: "FK_PROCESSO_REVISTA_RevistaId",
                        column: x => x.RevistaId,
                        principalTable: "REVISTA",
                        principalColumn: "RevistaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CLASSENICE",
                columns: table => new
                {
                    ClasseNiceId = table.Column<string>(type: "char(32)", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: true),
                    Especificacao = table.Column<string>(type: "varchar(max)", nullable: true),
                    ProcessoId = table.Column<string>(type: "char(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLASSENICE", x => x.ClasseNiceId);
                    table.ForeignKey(
                        name: "FK_CLASSENICE_PROCESSO_ProcessoId",
                        column: x => x.ProcessoId,
                        principalTable: "PROCESSO",
                        principalColumn: "ProcessoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CLASSESVIENNA",
                columns: table => new
                {
                    ClassesViennaId = table.Column<string>(type: "char(32)", nullable: false),
                    Edicao = table.Column<string>(type: "varchar(8000)", nullable: true),
                    ProcessoId = table.Column<string>(type: "char(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLASSESVIENNA", x => x.ClassesViennaId);
                    table.ForeignKey(
                        name: "FK_CLASSESVIENNA_PROCESSO_ProcessoId",
                        column: x => x.ProcessoId,
                        principalTable: "PROCESSO",
                        principalColumn: "ProcessoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DESPACHO",
                columns: table => new
                {
                    DespachoId = table.Column<string>(type: "char(32)", nullable: false),
                    Codigo = table.Column<string>(type: "varchar(8000)", nullable: true),
                    Nome = table.Column<string>(type: "varchar(8000)", nullable: true),
                    ProcessoId = table.Column<string>(type: "char(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DESPACHO", x => x.DespachoId);
                    table.ForeignKey(
                        name: "FK_DESPACHO_PROCESSO_ProcessoId",
                        column: x => x.ProcessoId,
                        principalTable: "PROCESSO",
                        principalColumn: "ProcessoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MARCA",
                columns: table => new
                {
                    MarcaId = table.Column<string>(type: "char(32)", nullable: false),
                    Apresentacao = table.Column<string>(type: "varchar(8000)", nullable: true),
                    Natureza = table.Column<string>(type: "varchar(8000)", nullable: true),
                    Nome = table.Column<string>(type: "varchar(8000)", nullable: true),
                    ProcessoId = table.Column<string>(type: "char(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MARCA", x => x.MarcaId);
                    table.ForeignKey(
                        name: "FK_MARCA_PROCESSO_ProcessoId",
                        column: x => x.ProcessoId,
                        principalTable: "PROCESSO",
                        principalColumn: "ProcessoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TITULAR",
                columns: table => new
                {
                    TitularId = table.Column<string>(type: "char(32)", nullable: false),
                    RazaoSocial = table.Column<string>(type: "varchar(8000)", nullable: true),
                    Pais = table.Column<string>(type: "varchar(100)", nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", nullable: true),
                    ProcessoId = table.Column<string>(type: "char(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TITULAR", x => x.TitularId);
                    table.ForeignKey(
                        name: "FK_TITULAR_PROCESSO_ProcessoId",
                        column: x => x.ProcessoId,
                        principalTable: "PROCESSO",
                        principalColumn: "ProcessoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CLASSEVIENNA",
                columns: table => new
                {
                    ClasseViennaId = table.Column<string>(type: "char(32)", nullable: false),
                    Codigo = table.Column<string>(type: "varchar(8000)", nullable: true),
                    ClassesViennaId = table.Column<string>(type: "char(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLASSEVIENNA", x => x.ClasseViennaId);
                    table.ForeignKey(
                        name: "FK_CLASSEVIENNA_CLASSESVIENNA_ClasseViennaId",
                        column: x => x.ClasseViennaId,
                        principalTable: "CLASSESVIENNA",
                        principalColumn: "ClassesViennaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLASSENICE_ProcessoId",
                table: "CLASSENICE",
                column: "ProcessoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CLASSESVIENNA_ProcessoId",
                table: "CLASSESVIENNA",
                column: "ProcessoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DESPACHO_ProcessoId",
                table: "DESPACHO",
                column: "ProcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_MARCA_ProcessoId",
                table: "MARCA",
                column: "ProcessoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PROCESSO_RevistaId",
                table: "PROCESSO",
                column: "RevistaId");

            migrationBuilder.CreateIndex(
                name: "IX_TITULAR_ProcessoId",
                table: "TITULAR",
                column: "ProcessoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLASSENICE");

            migrationBuilder.DropTable(
                name: "CLASSEVIENNA");

            migrationBuilder.DropTable(
                name: "DESPACHO");

            migrationBuilder.DropTable(
                name: "MARCA");

            migrationBuilder.DropTable(
                name: "TITULAR");

            migrationBuilder.DropTable(
                name: "CLASSESVIENNA");

            migrationBuilder.DropTable(
                name: "PROCESSO");

            migrationBuilder.DropTable(
                name: "REVISTA");
        }
    }
}
