using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedLoadersAndAllData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Environment",
                table: "ModProjects",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ModLoaderId",
                table: "ModProjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ModLoaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModLoaders", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Adventure");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Cursed");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Decoration");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Economy");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Equipment");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Food" },
                    { 7, "Game Mechanics" },
                    { 8, "Library" },
                    { 9, "Magic" },
                    { 10, "Management" },
                    { 11, "Minigame" },
                    { 12, "Mobs" },
                    { 13, "Optimization" },
                    { 14, "Social" },
                    { 15, "Storage" },
                    { 16, "Technology" },
                    { 17, "Transportation" },
                    { 18, "Utility" },
                    { 19, "World Generation" }
                });

            migrationBuilder.UpdateData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 1,
                column: "VersionNumber",
                value: "26.3");

            migrationBuilder.UpdateData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 2,
                column: "VersionNumber",
                value: "26.2");

            migrationBuilder.UpdateData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 3,
                column: "VersionNumber",
                value: "26.1.2");

            migrationBuilder.UpdateData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 4,
                column: "VersionNumber",
                value: "26.1.1");

            migrationBuilder.InsertData(
                table: "GameVersions",
                columns: new[] { "Id", "VersionNumber" },
                values: new object[,]
                {
                    { 5, "26.1" },
                    { 6, "1.21.11" },
                    { 7, "1.21.10" },
                    { 8, "1.21.9" },
                    { 9, "1.21.8" },
                    { 10, "1.21.7" },
                    { 11, "1.21.6" },
                    { 12, "1.21.5" },
                    { 13, "1.21.4" },
                    { 14, "1.21.3" },
                    { 15, "1.21.2" },
                    { 16, "1.21.1" },
                    { 17, "1.21" },
                    { 18, "1.20.6" },
                    { 19, "1.20.5" },
                    { 20, "1.20.4" },
                    { 21, "1.20.3" },
                    { 22, "1.20.2" },
                    { 23, "1.20.1" },
                    { 24, "1.20" },
                    { 25, "1.19.4" },
                    { 26, "1.19.3" },
                    { 27, "1.19.2" },
                    { 28, "1.19.1" },
                    { 29, "1.19" },
                    { 30, "1.18.2" },
                    { 31, "1.18.1" },
                    { 32, "1.18" },
                    { 33, "1.17.1" },
                    { 34, "1.17" },
                    { 35, "1.16.5" },
                    { 36, "1.16.4" },
                    { 37, "1.16.3" },
                    { 38, "1.16.2" },
                    { 39, "1.16.1" },
                    { 40, "1.16" },
                    { 41, "1.15.2" },
                    { 42, "1.15.1" },
                    { 43, "1.15" },
                    { 44, "1.14.4" },
                    { 45, "1.14.3" },
                    { 46, "1.14.2" },
                    { 47, "1.14.1" },
                    { 48, "1.14" },
                    { 49, "1.13.2" },
                    { 50, "1.13.1" },
                    { 51, "1.13" },
                    { 52, "1.12.2" },
                    { 53, "1.12.1" },
                    { 54, "1.12" },
                    { 55, "1.11.2" },
                    { 56, "1.11.1" },
                    { 57, "1.11" },
                    { 58, "1.10.2" },
                    { 59, "1.10.1" },
                    { 60, "1.10" },
                    { 61, "1.9.4" },
                    { 62, "1.9.3" },
                    { 63, "1.9.2" },
                    { 64, "1.9.1" },
                    { 65, "1.9" },
                    { 66, "1.8.9" },
                    { 67, "1.8.8" },
                    { 68, "1.8.7" },
                    { 69, "1.8.6" },
                    { 70, "1.8.5" },
                    { 71, "1.8.4" },
                    { 72, "1.8.3" },
                    { 73, "1.8.2" },
                    { 74, "1.8.1" },
                    { 75, "1.8" },
                    { 76, "1.7.10" },
                    { 77, "1.7.9" },
                    { 78, "1.7.8" },
                    { 79, "1.7.7" },
                    { 80, "1.7.6" },
                    { 81, "1.7.5" },
                    { 82, "1.7.4" },
                    { 83, "1.7.3" },
                    { 84, "1.7.2" },
                    { 85, "1.6.4" },
                    { 86, "1.6.2" },
                    { 87, "1.6.1" },
                    { 88, "1.5.2" },
                    { 89, "1.5.1" },
                    { 90, "1.4.7" },
                    { 91, "1.4.6" },
                    { 92, "1.4.5" },
                    { 93, "1.4.4" },
                    { 94, "1.4.2" },
                    { 95, "1.3.2" },
                    { 96, "1.3.1" },
                    { 97, "1.2.5" },
                    { 98, "1.2.4" },
                    { 99, "1.2.3" },
                    { 100, "1.2.2" },
                    { 101, "1.2.1" },
                    { 102, "1.1" },
                    { 103, "1.0" }
                });

            migrationBuilder.InsertData(
                table: "ModLoaders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fabric" },
                    { 2, "Forge" },
                    { 3, "NeoForge" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModProjects_ModLoaderId",
                table: "ModProjects",
                column: "ModLoaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModProjects_ModLoaders_ModLoaderId",
                table: "ModProjects",
                column: "ModLoaderId",
                principalTable: "ModLoaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModProjects_ModLoaders_ModLoaderId",
                table: "ModProjects");

            migrationBuilder.DropTable(
                name: "ModLoaders");

            migrationBuilder.DropIndex(
                name: "IX_ModProjects_ModLoaderId",
                table: "ModProjects");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DropColumn(
                name: "Environment",
                table: "ModProjects");

            migrationBuilder.DropColumn(
                name: "ModLoaderId",
                table: "ModProjects");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Optimization");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Shaders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Magic");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Tech");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "World Gen");

            migrationBuilder.UpdateData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 1,
                column: "VersionNumber",
                value: "1.21.1");

            migrationBuilder.UpdateData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 2,
                column: "VersionNumber",
                value: "1.20.4");

            migrationBuilder.UpdateData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 3,
                column: "VersionNumber",
                value: "1.19.4");

            migrationBuilder.UpdateData(
                table: "GameVersions",
                keyColumn: "Id",
                keyValue: 4,
                column: "VersionNumber",
                value: "1.18.2");
        }
    }
}
