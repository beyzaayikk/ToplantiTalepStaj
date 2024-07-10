using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToplantiTalep.Migrations
{
    public partial class mig_data3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_taleps_kurums_KurumID",
                table: "taleps");

            migrationBuilder.DropIndex(
                name: "IX_taleps_KurumID",
                table: "taleps");

            migrationBuilder.DropColumn(
                name: "KurumID",
                table: "taleps");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KurumID",
                table: "taleps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_taleps_KurumID",
                table: "taleps",
                column: "KurumID");

            migrationBuilder.AddForeignKey(
                name: "FK_taleps_kurums_KurumID",
                table: "taleps",
                column: "KurumID",
                principalTable: "kurums",
                principalColumn: "KurumID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
