using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 879, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 879, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 882, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 882, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.CreateIndex(
                name: "IX_AllowModification_MarkId",
                table: "AllowModification",
                column: "MarkId");

            migrationBuilder.AddForeignKey(
                name: "FK_AllowModification_Mark_MarkId",
                table: "AllowModification",
                column: "MarkId",
                principalTable: "Mark",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AllowModification_Mark_MarkId",
                table: "AllowModification");

            migrationBuilder.DropIndex(
                name: "IX_AllowModification_MarkId",
                table: "AllowModification");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 718, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 718, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3411));
        }
    }
}
