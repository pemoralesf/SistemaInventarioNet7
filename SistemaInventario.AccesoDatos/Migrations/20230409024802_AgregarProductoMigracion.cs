using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaInventario.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarProductoMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroSerie = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    ImagenUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    PadreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbProductos_TbCategorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "TbCategorias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TbProductos_TbMarcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "TbMarcas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TbProductos_TbProductos_PadreId",
                        column: x => x.PadreId,
                        principalTable: "TbProductos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbProductos_CategoriaId",
                table: "TbProductos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_TbProductos_MarcaId",
                table: "TbProductos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_TbProductos_PadreId",
                table: "TbProductos",
                column: "PadreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbProductos");
        }
    }
}
