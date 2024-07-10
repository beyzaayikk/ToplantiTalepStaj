using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToplantiTalep.Migrations
{
    public partial class mig_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AdminSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AdminMail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AdminTelNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AdminParola = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "departmen",
                columns: table => new
                {
                    DepartmanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAd = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departmen", x => x.DepartmanID);
                });

            migrationBuilder.CreateTable(
                name: "kurums",
                columns: table => new
                {
                    KurumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KurumAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kurums", x => x.KurumID);
                });

            migrationBuilder.CreateTable(
                name: "toplantiTurs",
                columns: table => new
                {
                    ToplantiTurID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToplantiTurAciklama = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toplantiTurs", x => x.ToplantiTurID);
                });

            migrationBuilder.CreateTable(
                name: "odas",
                columns: table => new
                {
                    OdaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OdaKat = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    OdaNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DepartmanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_odas", x => x.OdaID);
                    table.ForeignKey(
                        name: "FK_odas_departmen_DepartmanID",
                        column: x => x.DepartmanID,
                        principalTable: "departmen",
                        principalColumn: "DepartmanID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "kullanicis",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KullaniciSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KullaniciMail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KullaniciTelNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KullaniciUnvan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KullaniciParola = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KurumID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kullanicis", x => x.KullaniciID);
                    table.ForeignKey(
                        name: "FK_kullanicis_kurums_KurumID",
                        column: x => x.KurumID,
                        principalTable: "kurums",
                        principalColumn: "KurumID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "taleps",
                columns: table => new
                {
                    TalepID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TalepAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnvanterTalep = table.Column<bool>(type: "bit", nullable: false),
                    EnvanterAciklama = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    DepartmanID = table.Column<int>(type: "int", nullable: false),
                    KurumID = table.Column<int>(type: "int", nullable: false),
                    OdaID = table.Column<int>(type: "int", nullable: false),
                    ToplantiTurID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taleps", x => x.TalepID);
                    table.ForeignKey(
                        name: "FK_taleps_departmen_DepartmanID",
                        column: x => x.DepartmanID,
                        principalTable: "departmen",
                        principalColumn: "DepartmanID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_taleps_kullanicis_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "kullanicis",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_taleps_kurums_KurumID",
                        column: x => x.KurumID,
                        principalTable: "kurums",
                        principalColumn: "KurumID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_taleps_odas_OdaID",
                        column: x => x.OdaID,
                        principalTable: "odas",
                        principalColumn: "OdaID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_taleps_toplantiTurs_ToplantiTurID",
                        column: x => x.ToplantiTurID,
                        principalTable: "toplantiTurs",
                        principalColumn: "ToplantiTurID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_kullanicis_KurumID",
                table: "kullanicis",
                column: "KurumID");

            migrationBuilder.CreateIndex(
                name: "IX_odas_DepartmanID",
                table: "odas",
                column: "DepartmanID");

            migrationBuilder.CreateIndex(
                name: "IX_taleps_DepartmanID",
                table: "taleps",
                column: "DepartmanID");

            migrationBuilder.CreateIndex(
                name: "IX_taleps_KullaniciID",
                table: "taleps",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_taleps_KurumID",
                table: "taleps",
                column: "KurumID");

            migrationBuilder.CreateIndex(
                name: "IX_taleps_OdaID",
                table: "taleps",
                column: "OdaID");

            migrationBuilder.CreateIndex(
                name: "IX_taleps_ToplantiTurID",
                table: "taleps",
                column: "ToplantiTurID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "taleps");

            migrationBuilder.DropTable(
                name: "kullanicis");

            migrationBuilder.DropTable(
                name: "odas");

            migrationBuilder.DropTable(
                name: "toplantiTurs");

            migrationBuilder.DropTable(
                name: "kurums");

            migrationBuilder.DropTable(
                name: "departmen");
        }
    }
}
