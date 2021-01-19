using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace formulaTopTen.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "driver",
                columns: table => new
                {
                    driverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_driver", x => x.driverId);
                });

            migrationBuilder.CreateTable(
                name: "coment",
                columns: table => new
                {
                    comentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    coment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    driverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coment", x => x.comentId);
                    table.ForeignKey(
                        name: "FK_coment_driver_driverId",
                        column: x => x.driverId,
                        principalTable: "driver",
                        principalColumn: "driverId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_coment_driverId",
                table: "coment",
                column: "driverId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coment");

            migrationBuilder.DropTable(
                name: "driver");
        }
    }
}
