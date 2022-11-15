using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace locadoradeveiculos.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    idade = table.Column<int>(type: "int", nullable: false),
                    endereco = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    estado = table.Column<int>(type: "int", nullable: false),
                    cep = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    placa = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    ano = table.Column<int>(type: "int", nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fabricante = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Alugueis",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataAluguel = table.Column<DateTime>(type: "datetime2", nullable: false),
                    funcionarioid = table.Column<int>(type: "int", nullable: false),
                    clienteid = table.Column<int>(type: "int", nullable: false),
                    veiculoid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alugueis", x => x.id);
                    table.ForeignKey(
                        name: "FK_Alugueis_Clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alugueis_Funcionarios_funcionarioid",
                        column: x => x.funcionarioid,
                        principalTable: "Funcionarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alugueis_Veiculos_veiculoid",
                        column: x => x.veiculoid,
                        principalTable: "Veiculos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_clienteid",
                table: "Alugueis",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_funcionarioid",
                table: "Alugueis",
                column: "funcionarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_veiculoid",
                table: "Alugueis",
                column: "veiculoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alugueis");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
