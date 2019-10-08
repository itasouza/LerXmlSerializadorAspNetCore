using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.GravacaoXML.Migrations
{
    public partial class BancoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "REVISTA",
                columns: table => new
                {
                    RevistaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<string>(type: "varchar", maxLength: 20, nullable: true),
                    Data = table.Column<string>(type: "varchar", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REVISTA", x => x.RevistaId);
                });

            migrationBuilder.CreateTable(
                name: "PROCESSO",
                columns: table => new
                {
                    ProcessoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<string>(type: "varchar", maxLength: 20, nullable: false),
                    DataDoDeposito = table.Column<string>(type: "varchar", maxLength: 20, nullable: false),
                    RevistaId = table.Column<int>(nullable: false),
                    Apostila = table.Column<string>(type: "varchar", maxLength: 200, nullable: true),
                    Procurador = table.Column<string>(type: "varchar", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROCESSO", x => x.ProcessoId);
                    table.ForeignKey(
                        name: "FK_PROCESSO_REVISTA_RevistaId",
                        column: x => x.RevistaId,
                        principalTable: "REVISTA",
                        principalColumn: "RevistaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CLASSENICE",
                columns: table => new
                {
                    ClasseNiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(type: "varchar", maxLength: 20, nullable: true),
                    Especificacao = table.Column<string>(type: "varchar", maxLength: 1000, nullable: true),
                    ProcessoId = table.Column<int>(nullable: false)
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
                    ClassesViennaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Edicao = table.Column<string>(type: "varchar", maxLength: 200, nullable: true),
                    ProcessoId = table.Column<int>(nullable: false)
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
                    DespachoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(type: "varchar", maxLength: 20, nullable: true),
                    Nome = table.Column<string>(type: "varchar", maxLength: 200, nullable: false),
                    ProcessoId = table.Column<int>(nullable: false)
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
                    MarcaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apresentacao = table.Column<string>(type: "varchar", maxLength: 200, nullable: true),
                    Natureza = table.Column<string>(type: "varchar", maxLength: 200, nullable: true),
                    Nome = table.Column<string>(type: "varchar", maxLength: 200, nullable: true),
                    ProcessoId = table.Column<int>(nullable: false)
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
                    TitularId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RazaoSocial = table.Column<string>(type: "varchar", maxLength: 200, nullable: true),
                    Pais = table.Column<string>(type: "varchar", maxLength: 100, nullable: true),
                    UF = table.Column<string>(type: "varchar", maxLength: 2, nullable: true),
                    ProcessoId = table.Column<int>(nullable: false)
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
                    ClasseViennaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(type: "varchar", maxLength: 20, nullable: true),
                    ClassesViennaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLASSEVIENNA", x => x.ClasseViennaId);
                    table.ForeignKey(
                        name: "FK_CLASSEVIENNA_CLASSESVIENNA_ClassesViennaId",
                        column: x => x.ClassesViennaId,
                        principalTable: "CLASSESVIENNA",
                        principalColumn: "ClassesViennaId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_CLASSEVIENNA_ClassesViennaId",
                table: "CLASSEVIENNA",
                column: "ClassesViennaId");

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
