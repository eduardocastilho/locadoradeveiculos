using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace locadoradeveiculos.Migrations
{
    public partial class VeiculoID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Veiculos_id_veiculo",
                table: "Alugueis");

            migrationBuilder.RenameColumn(
                name: "id_veiculo",
                table: "Alugueis",
                newName: "veiculoid");

            migrationBuilder.RenameIndex(
                name: "IX_Alugueis_id_veiculo",
                table: "Alugueis",
                newName: "IX_Alugueis_veiculoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Veiculos_veiculoid",
                table: "Alugueis",
                column: "veiculoid",
                principalTable: "Veiculos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Veiculos_veiculoid",
                table: "Alugueis");

            migrationBuilder.RenameColumn(
                name: "veiculoid",
                table: "Alugueis",
                newName: "id_veiculo");

            migrationBuilder.RenameIndex(
                name: "IX_Alugueis_veiculoid",
                table: "Alugueis",
                newName: "IX_Alugueis_id_veiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Veiculos_id_veiculo",
                table: "Alugueis",
                column: "id_veiculo",
                principalTable: "Veiculos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
