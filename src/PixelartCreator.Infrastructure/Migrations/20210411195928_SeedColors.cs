using Microsoft.EntityFrameworkCore.Migrations;

namespace PixelartCreator.Infrastructure.Migrations
{
    public partial class SeedColors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "A", "B", "G", "R" },
                values: new object[,]
                {
                    { 1, (byte)255, (byte)56, (byte)178, (byte)127 },
                    { 32, (byte)255, (byte)255, (byte)128, (byte)74 },
                    { 33, (byte)255, (byte)58, (byte)217, (byte)0 },
                    { 34, (byte)255, (byte)49, (byte)86, (byte)129 },
                    { 35, (byte)255, (byte)0, (byte)2, (byte)112 },
                    { 36, (byte)255, (byte)161, (byte)177, (byte)209 },
                    { 37, (byte)255, (byte)36, (byte)82, (byte)159 },
                    { 38, (byte)255, (byte)108, (byte)87, (byte)149 },
                    { 39, (byte)255, (byte)138, (byte)108, (byte)112 },
                    { 40, (byte)255, (byte)36, (byte)133, (byte)186 },
                    { 41, (byte)255, (byte)53, (byte)117, (byte)103 },
                    { 42, (byte)255, (byte)78, (byte)77, (byte)160 },
                    { 43, (byte)255, (byte)35, (byte)41, (byte)57 },
                    { 44, (byte)255, (byte)98, (byte)107, (byte)135 },
                    { 45, (byte)255, (byte)92, (byte)92, (byte)87 },
                    { 46, (byte)255, (byte)88, (byte)73, (byte)122 },
                    { 47, (byte)255, (byte)92, (byte)62, (byte)76 },
                    { 48, (byte)255, (byte)35, (byte)50, (byte)76 },
                    { 49, (byte)255, (byte)42, (byte)82, (byte)76 },
                    { 50, (byte)255, (byte)46, (byte)60, (byte)142 },
                    { 51, (byte)255, (byte)16, (byte)22, (byte)37 },
                    { 52, (byte)255, (byte)49, (byte)48, (byte)189 },
                    { 53, (byte)255, (byte)97, (byte)63, (byte)148 },
                    { 54, (byte)255, (byte)29, (byte)25, (byte)92 },
                    { 55, (byte)255, (byte)134, (byte)126, (byte)22 },
                    { 56, (byte)255, (byte)140, (byte)142, (byte)58 },
                    { 31, (byte)255, (byte)213, (byte)219, (byte)92 },
                    { 30, (byte)255, (byte)77, (byte)238, (byte)250 },
                    { 29, (byte)255, (byte)25, (byte)25, (byte)25 },
                    { 28, (byte)255, (byte)51, (byte)51, (byte)153 },
                    { 2, (byte)255, (byte)163, (byte)233, (byte)247 },
                    { 3, (byte)255, (byte)199, (byte)199, (byte)199 },
                    { 4, (byte)255, (byte)0, (byte)0, (byte)255 },
                    { 5, (byte)255, (byte)255, (byte)160, (byte)160 },
                    { 6, (byte)255, (byte)167, (byte)167, (byte)167 },
                    { 7, (byte)255, (byte)0, (byte)124, (byte)0 },
                    { 8, (byte)255, (byte)255, (byte)255, (byte)255 },
                    { 9, (byte)255, (byte)184, (byte)168, (byte)164 },
                    { 10, (byte)255, (byte)77, (byte)109, (byte)151 },
                    { 11, (byte)255, (byte)112, (byte)112, (byte)112 },
                    { 12, (byte)255, (byte)255, (byte)64, (byte)64 },
                    { 13, (byte)255, (byte)72, (byte)119, (byte)143 }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "A", "B", "G", "R" },
                values: new object[,]
                {
                    { 57, (byte)255, (byte)62, (byte)44, (byte)86 },
                    { 14, (byte)255, (byte)245, (byte)252, (byte)255 },
                    { 16, (byte)255, (byte)216, (byte)76, (byte)178 },
                    { 17, (byte)255, (byte)216, (byte)153, (byte)102 },
                    { 18, (byte)255, (byte)51, (byte)229, (byte)229 },
                    { 19, (byte)255, (byte)25, (byte)204, (byte)127 },
                    { 20, (byte)255, (byte)165, (byte)127, (byte)242 },
                    { 21, (byte)255, (byte)76, (byte)76, (byte)76 },
                    { 22, (byte)255, (byte)153, (byte)153, (byte)153 },
                    { 23, (byte)255, (byte)153, (byte)127, (byte)76 },
                    { 24, (byte)255, (byte)178, (byte)63, (byte)127 },
                    { 25, (byte)255, (byte)178, (byte)76, (byte)51 },
                    { 26, (byte)255, (byte)51, (byte)76, (byte)102 },
                    { 27, (byte)255, (byte)51, (byte)127, (byte)102 },
                    { 15, (byte)255, (byte)51, (byte)127, (byte)216 },
                    { 58, (byte)255, (byte)133, (byte)180, (byte)20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 58);
        }
    }
}
