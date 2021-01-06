using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DataCadastro",
            //    schema: "dbo",
            //    table: "NotasSugerida",
            //    type: "datetime2",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "Datetime");

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "Notas",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 16, 21, 6, 0, DateTimeKind.Unspecified));

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "Notas",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 16, 21, 6, 0, DateTimeKind.Unspecified));

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "Notas",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 16, 21, 6, 0, DateTimeKind.Unspecified));

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "Notas",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 16, 21, 6, 0, DateTimeKind.Unspecified));

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "Notas",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 16, 21, 6, 0, DateTimeKind.Unspecified));

            //migrationBuilder.InsertData(
            //    schema: "dbo",
            //    table: "NotasSugerida",
            //    columns: new[] { "Id", "Ativo", "DataCadastro", "NotasId", "ValorNotaSugerida" },
            //    values: new object[] { 1, true, new DateTime(2021, 1, 2, 16, 21, 6, 787, DateTimeKind.Local).AddTicks(3370), 1, 5m });

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "TipoCliente",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 16, 21, 6, 0, DateTimeKind.Unspecified));

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "TipoCliente",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 16, 21, 6, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotasSugerida",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                schema: "dbo",
                table: "NotasSugerida",
                type: "Datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified));
        }
    }
}
