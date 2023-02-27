using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace app.Migrations
{
    /// <inheritdoc />
    public partial class OverRide : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sector",
                table: "tb_employess",
                newName: "sector");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "tb_employess",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tb_employess",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_employess",
                newName: "id");

            migrationBuilder.UpdateData(
                table: "tb_employess",
                keyColumn: "sector",
                keyValue: null,
                column: "sector",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "sector",
                table: "tb_employess",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "tb_employess",
                keyColumn: "role",
                keyValue: null,
                column: "role",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "role",
                table: "tb_employess",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "tb_employess",
                keyColumn: "name",
                keyValue: null,
                column: "name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "tb_employess",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "tb_employess",
                columns: new[] { "id", "name", "role", "sector" },
                values: new object[,]
                {
                    { 1, "Levi Mário Levi Monteiro", "CEO", "Administrativo" },
                    { 2, "Raquel Andreia Emilly Fogaça", "CTO", "Administrativo" },
                    { 3, "Sônia Carolina Marcela da Silva", "Contabilidade", "Financeiro" },
                    { 4, "Luiz Hugo Renan Dias", "Gestor de pessoas", "Recursos Humanos" },
                    { 5, "Antônia Bianca Lara Almeida", "DevOps", "Operacional" },
                    { 6, "Hugo Cauê Carlos Eduardo Martins", "Dev FrontEnd", "Operacional" },
                    { 7, "Cauê Matheus Nicolas Santos", "Dev BacktEnd", "Operacional" },
                    { 8, "Elias Luís Moreira", "PO", "Comercial" },
                    { 9, "Eliane Melissa Barros", "Marketing", "Comercial" },
                    { 10, "José Hugo Araújo", "Atendimento", "Comercial" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tb_employess",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tb_employess",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tb_employess",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tb_employess",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tb_employess",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tb_employess",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "tb_employess",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "tb_employess",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tb_employess",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "tb_employess",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "sector",
                table: "tb_employess",
                newName: "Sector");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "tb_employess",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "tb_employess",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tb_employess",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Sector",
                table: "tb_employess",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "tb_employess",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tb_employess",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
