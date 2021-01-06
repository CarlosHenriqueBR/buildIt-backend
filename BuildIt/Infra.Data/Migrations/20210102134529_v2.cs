using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DataCadastro",
            //    schema: "dbo",
            //    table: "Notas",
            //    type: "datetime2",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "Datetime");

            //migrationBuilder.InsertData(
            //    schema: "dbo",
            //    table: "Notas",
            //    columns: new[] { "Id", "Ativo", "DataCadastro", "Descricao", "Disponivel" },
            //    values: new object[,]
            //    {
            //        { 1, true, new DateTime(2021, 1, 2, 10, 45, 28, 0, DateTimeKind.Unspecified), 5m, true },
            //        { 2, true, new DateTime(2021, 1, 2, 10, 45, 28, 0, DateTimeKind.Unspecified), 10m, true },
            //        { 3, true, new DateTime(2021, 1, 2, 10, 45, 28, 0, DateTimeKind.Unspecified), 20m, true },
            //        { 4, true, new DateTime(2021, 1, 2, 10, 45, 28, 0, DateTimeKind.Unspecified), 50m, true },
            //        { 5, true, new DateTime(2021, 1, 2, 10, 45, 28, 0, DateTimeKind.Unspecified), 100m, true }
            //    });

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "TipoCliente",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 10, 45, 28, 0, DateTimeKind.Unspecified));

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "TipoCliente",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 10, 45, 28, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                schema: "dbo",
                table: "Notas",
                type: "Datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 10, 15, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 10, 15, 59, 0, DateTimeKind.Unspecified));
        }
    }
}
