using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace locadoradeveiculos.Migrations
{
    public partial class CorrecaoID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Clientes_id_cliente",
                table: "Alugueis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Funcionarios_id_funcionario",
                table: "Alugueis");

            migrationBuilder.RenameColumn(
                name: "id_funcionario",
                table: "Alugueis",
                newName: "funcionarioid");

            migrationBuilder.RenameColumn(
                name: "id_cliente",
                table: "Alugueis",
                newName: "clienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Alugueis_id_funcionario",
                table: "Alugueis",
                newName: "IX_Alugueis_funcionarioid");

            migrationBuilder.RenameIndex(
                name: "IX_Alugueis_id_cliente",
                table: "Alugueis",
                newName: "IX_Alugueis_clienteid");

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Clientes_clienteid",
                table: "Alugueis",
                column: "clienteid",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Funcionarios_funcionarioid",
                table: "Alugueis",
                column: "funcionarioid",
                principalTable: "Funcionarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Clientes_clienteid",
                table: "Alugueis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Funcionarios_funcionarioid",
                table: "Alugueis");

            migrationBuilder.RenameColumn(
                name: "funcionarioid",
                table: "Alugueis",
                newName: "id_funcionario");

            migrationBuilder.RenameColumn(
                name: "clienteid",
                table: "Alugueis",
                newName: "id_cliente");

            migrationBuilder.RenameIndex(
                name: "IX_Alugueis_funcionarioid",
                table: "Alugueis",
                newName: "IX_Alugueis_id_funcionario");

            migrationBuilder.RenameIndex(
                name: "IX_Alugueis_clienteid",
                table: "Alugueis",
                newName: "IX_Alugueis_id_cliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Clientes_id_cliente",
                table: "Alugueis",
                column: "id_cliente",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Funcionarios_id_funcionario",
                table: "Alugueis",
                column: "id_funcionario",
                principalTable: "Funcionarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
