using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToplantiTalep.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kullanicis_kurums_KurumID",
                table: "kullanicis");

            migrationBuilder.DropForeignKey(
                name: "FK_odas_departmen_DepartmanID",
                table: "odas");

            migrationBuilder.DropForeignKey(
                name: "FK_taleps_departmen_DepartmanID",
                table: "taleps");

            migrationBuilder.DropForeignKey(
                name: "FK_taleps_kullanicis_KullaniciID",
                table: "taleps");

            migrationBuilder.DropForeignKey(
                name: "FK_taleps_odas_OdaID",
                table: "taleps");

            migrationBuilder.DropForeignKey(
                name: "FK_taleps_toplantiTurs_ToplantiTurID",
                table: "taleps");

            migrationBuilder.DropIndex(
                name: "IX_taleps_KullaniciID",
                table: "taleps");

            migrationBuilder.DropIndex(
                name: "IX_taleps_OdaID",
                table: "taleps");

            migrationBuilder.DropIndex(
                name: "IX_taleps_ToplantiTurID",
                table: "taleps");

            migrationBuilder.DropIndex(
                name: "IX_kullanicis_KurumID",
                table: "kullanicis");

            migrationBuilder.DropColumn(
                name: "KullaniciID",
                table: "taleps");

            migrationBuilder.DropColumn(
                name: "OdaID",
                table: "taleps");

            migrationBuilder.DropColumn(
                name: "ToplantiTurID",
                table: "taleps");

            migrationBuilder.DropColumn(
                name: "KurumID",
                table: "kullanicis");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmanID",
                table: "taleps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmanID",
                table: "odas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_odas_departmen_DepartmanID",
                table: "odas",
                column: "DepartmanID",
                principalTable: "departmen",
                principalColumn: "DepartmanID");

            migrationBuilder.AddForeignKey(
                name: "FK_taleps_departmen_DepartmanID",
                table: "taleps",
                column: "DepartmanID",
                principalTable: "departmen",
                principalColumn: "DepartmanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_odas_departmen_DepartmanID",
                table: "odas");

            migrationBuilder.DropForeignKey(
                name: "FK_taleps_departmen_DepartmanID",
                table: "taleps");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmanID",
                table: "taleps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KullaniciID",
                table: "taleps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OdaID",
                table: "taleps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToplantiTurID",
                table: "taleps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmanID",
                table: "odas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KurumID",
                table: "kullanicis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_taleps_KullaniciID",
                table: "taleps",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_taleps_OdaID",
                table: "taleps",
                column: "OdaID");

            migrationBuilder.CreateIndex(
                name: "IX_taleps_ToplantiTurID",
                table: "taleps",
                column: "ToplantiTurID");

            migrationBuilder.CreateIndex(
                name: "IX_kullanicis_KurumID",
                table: "kullanicis",
                column: "KurumID");

            migrationBuilder.AddForeignKey(
                name: "FK_kullanicis_kurums_KurumID",
                table: "kullanicis",
                column: "KurumID",
                principalTable: "kurums",
                principalColumn: "KurumID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_odas_departmen_DepartmanID",
                table: "odas",
                column: "DepartmanID",
                principalTable: "departmen",
                principalColumn: "DepartmanID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_taleps_departmen_DepartmanID",
                table: "taleps",
                column: "DepartmanID",
                principalTable: "departmen",
                principalColumn: "DepartmanID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_taleps_kullanicis_KullaniciID",
                table: "taleps",
                column: "KullaniciID",
                principalTable: "kullanicis",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_taleps_odas_OdaID",
                table: "taleps",
                column: "OdaID",
                principalTable: "odas",
                principalColumn: "OdaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_taleps_toplantiTurs_ToplantiTurID",
                table: "taleps",
                column: "ToplantiTurID",
                principalTable: "toplantiTurs",
                principalColumn: "ToplantiTurID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
