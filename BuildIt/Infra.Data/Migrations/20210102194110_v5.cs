using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 41, 8, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 41, 8, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 41, 8, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 41, 8, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 41, 8, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 41, 8, 984, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "NotasSugerida",
                columns: new[] { "Id", "Ativo", "DataCadastro", "NotasId", "ValorNotaSugerida" },
                values: new object[,]
                {
                    { 2, true, new DateTime(2021, 1, 2, 16, 41, 8, 985, DateTimeKind.Local).AddTicks(318), 2, 5m },
                    { 15, true, new DateTime(2021, 1, 2, 16, 41, 8, 985, DateTimeKind.Local).AddTicks(363), 5, 100m },
                    { 14, true, new DateTime(2021, 1, 2, 16, 41, 8, 985, DateTimeKind.Local).AddTicks(360), 5, 50m },
                    { 13, true, new DateTime(2021, 1, 2, 16, 41, 8, 985, DateTimeKind.Local).AddTicks(357), 5, 20m },
                    { 12, true, new DateTime(2021, 1, 2, 16, 41, 8, 985, DateTimeKind.Local).AddTicks(355), 5, 10m },
                    { 11, true, new DateTime(2021, 1, 2, 16, 41, 8, 985, DateTimeKind.Local).AddTicks(353), 5, 5m },
                    { 10, true, new DateTime(2021, 1, 2, 16, 41, 8, 985, DateTimeKind.Local).AddTicks(350), 4, 50m },
                    { 9, true, new DateTime(2021, 1, 2, 16, 41, 8, 985, DateTimeKind.Local).AddTicks(348), 4, 20m },
                    { 8, true, new DateTime(2021, 1, 2, 16, 41, 8, 985, DateTimeKind.Local).AddTicks(344), 4, 10m },
                    { 7, true, new DateTime(2021, 1, 2, 16, 41, 8, 985, DateTimeKind.Local).AddTicks(341), 4, 5m },
                    { 6, true, new DateTime(2021, 1, 2, 16, 41, 8, 985, DateTimeKind.Local).AddTicks(339), 3, 20m },
                    { 5, true, new DateTime(2021, 1, 2, 16, 41, 8, 985, DateTimeKind.Local).AddTicks(336), 3, 10m },
                    { 4, true, new DateTime(2021, 1, 2, 16, 41, 8, 985, DateTimeKind.Local).AddTicks(333), 3, 5m },
                    { 3, true, new DateTime(2021, 1, 2, 16, 41, 8, 985, DateTimeKind.Local).AddTicks(330), 2, 10m }
                });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 41, 8, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 41, 8, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 21, 6, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 21, 6, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 21, 6, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 21, 6, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 21, 6, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 21, 6, 787, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 21, 6, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 21, 6, 0, DateTimeKind.Unspecified));
        }
    }
}
