using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace app.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_employess",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sector = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    role = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_employess", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "8d52c894-cec6-4833-8145-0c801aad56ff", "Administrativo", "ADMINISTRATIVO" },
                    { "2", "cfcde936-2619-4185-aa06-449d76f0ebbf", "Financeiro", "FINANCEIRO" },
                    { "3", "0379e905-ef81-45a2-8ae5-272adb2b1536", "Recursos Humanos", "RECURSOS HUMANOS" },
                    { "4", "42dc39b3-43f4-4216-ab90-8e6be56daadd", "Operacional", "OPERACIONAL" },
                    { "5", "789bdd4c-8562-42c2-ab53-6a97779a0b95", "Comercial", "COMERCIAL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "2f8ee969-51e1-48da-b7bb-4890c0c461bb", "monteirolevi@admin.com", true, false, null, "MONTEIROLEVI@ADMIN.COM", "MONTEIROLEVI@ADMIN.COM", "AQAAAAEAACcQAAAAEPxtMnG1uQxNHqbrCb3nHOwCMS+D5hy8hGVYddoY2DJZMnCN/oeYQssijuCZr7O/LA==", null, false, "", false, "monteirolevi@admin.com" },
                    { "10", 0, "40e2accb-cf22-4c1d-a24a-d4332f6efb17", "araujojose@comercial.com", true, false, null, "ARAUJOJOSE@COMERCIAL.COM", "ARAUJOJOSE@COMERCIAL.COM", "AQAAAAEAACcQAAAAELIYWuwbAXuP5eLR//f7bJ4qUXagaJoodgo+tmqT8/PjJ2iwANEhgSEpqEll6wbkWA==", null, false, "", false, "araujojose@comercial.com" },
                    { "2", 0, "f7037b39-3b59-4bbb-a80c-889b144373aa", "emillyraquel@admin.com", true, false, null, "EMELLYRAQUEL@ADMIN.COM", "EMELLYRAQUEL@ADMIN.COM", "AQAAAAEAACcQAAAAENjvoKRgcS77g0oInrLRjfjKSN+pM91rZL1AmEiZCqIikC7r+Me1QHs08B/QYLVohQ==", null, false, "", false, "emillyraquel@admin.com" },
                    { "3", 0, "752b9146-2ce7-4cc9-8c75-bffb18fc66d3", "marcelasonia@finan.com", true, false, null, "MARCELASONIA@FINAN.COM", "MARCELASONIA@FINAN.COM", "AQAAAAEAACcQAAAAEDoTah6j8CX2ePgCEK17U3msQDgnJFBnoYkgzRENIntTmic97cJKediNNaY38fp3Ag==", null, false, "", false, "marcelasonia@finan.com" },
                    { "4", 0, "3bffcdc8-703b-4846-91ce-401b236da9be", "renanluiz@rh.com", true, false, null, "RENANLUIZ@RH.COM", "RENANLUIZ@RH.COM", "AQAAAAEAACcQAAAAEP6xkJw+vwM7JdUogDBCUsiKsX3b1JKhet5OSKN2QcH0I2jcATztoUlbGKR+vTKqZw==", null, false, "", false, "renanluiz@rh.com" },
                    { "5", 0, "b2a05f15-449a-4ed3-8a17-a6f22a4efc1b", "biancalara@opera.com", true, false, null, "BIANCALARA@OPERA.COM", "BIANCALARA@OPERA.COM", "AQAAAAEAACcQAAAAEEo5Zh3wrk54RjNEjUIea+xAHpCtMc+4PTU0QZwpo3TLO72Aip+uUB0zOYApkUsPlw==", null, false, "", false, "biancalara@opera.com" },
                    { "6", 0, "87311d15-7752-4500-89df-928d0438bee4", "cauecarlos@opera.com", true, false, null, "CAUECARLOS@OPERA.COM", "CAUECARLOS@OPERA.COM", "AQAAAAEAACcQAAAAEAkKZYw3+O3BbGNxx598gauBSME4EIFuTg970PdBpiJ79XHFYwX9mCKlowiJepQLlA==", null, false, "", false, "cauecarlos@opera.com" },
                    { "7", 0, "3582ed15-b3fe-4516-8999-60ccc9eab190", "cauematheus@opera.com", true, false, null, "CAUEMATHEUS@OPERA.COM", "CAUEMATHEUS@OPERA.COM", "AQAAAAEAACcQAAAAENBhZCU3lOu3pyy9i2wWjqh6C6gYUgWccKwSNmuvgM2yx8gXNY/QwMzW0RhaKBFLGg==", null, false, "", false, "cauematheus@opera.com" },
                    { "8", 0, "ad4cf650-487b-4f7c-b36e-ce612cc98b5d", "luiselias@comercial.com", true, false, null, "LUISELIAS@COMERCIAL.COM", "LUISELIAS@COMERCIAL.COM", "AQAAAAEAACcQAAAAEH3aZnRVJ0e51EQIhVauMUU7Yg+N7qhUv2iPEZ7kv2p5s1FMFUiyf/UotJJaZL4Viw==", null, false, "", false, "luiselias@comercial.com" },
                    { "9", 0, "794e9281-2f2e-49d8-81b1-aba0050a30e9", "barroseliane@comercial.com", true, false, null, "BARROSELIANE@COMERCIAL.COM", "BARROSELIANE@COMERCIAL.COM", "AQAAAAEAACcQAAAAEHxA9tZf0PqInzF4ZYv8LQpgSvAwTt/cQrxVk1r4hm02bSbvFnzXNcS5lfOjJSQd4w==", null, false, "", false, "barroseliane@comercial.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { -2047716072, "Operacional", "Read", "7" },
                    { -2010320002, "Comercial", "Read", "9" },
                    { -1203762942, "Comercial", "Read", "8" },
                    { -730306230, "Administrativo", "Create,Read,Update,Delete", "1" },
                    { -156103649, "Recursos Humanos", "Create,Read,Update,Delete", "4" },
                    { -20566640, "Administrativo", "Create,Read,Update,Delete", "2" },
                    { 63421998, "Financeiro", "Read", "3" },
                    { 150220408, "Operacional", "Read", "5" },
                    { 317725475, "Comercial", "Read", "10" },
                    { 979608038, "Operacional", "Read", "6" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "5", "10" },
                    { "1", "2" },
                    { "2", "3" },
                    { "3", "4" },
                    { "4", "5" },
                    { "4", "6" },
                    { "4", "7" },
                    { "5", "8" },
                    { "5", "9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "tb_employess");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
