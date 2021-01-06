using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "Descricao",
            //    schema: "dbo",
            //    table: "Notas",
            //    newName: "ValorNota");

            //migrationBuilder.CreateTable(
            //    name: "NotasSugerida",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ValorNotaSugerida = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        NotasId = table.Column<int>(type: "int", nullable: false),
            //        DataCadastro = table.Column<DateTime>(type: "Datetime", nullable: false),
            //        Ativo = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_NotasSugerida", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_NotasSugerida_Notas_NotasId",
            //            column: x => x.NotasId,
            //            principalSchema: "dbo",
            //            principalTable: "Notas",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "Notas",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified));

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "Notas",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified));

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "Notas",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified));

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "Notas",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified));

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "Notas",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified));

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "TipoCliente",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified));

            //migrationBuilder.UpdateData(
            //    schema: "dbo",
            //    table: "TipoCliente",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "DataCadastro",
            //    value: new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified));

            //migrationBuilder.CreateIndex(
            //    name: "IX_NotasSugerida_NotasId",
            //    schema: "dbo",
            //    table: "NotasSugerida",
            //    column: "NotasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotasSugerida",
                schema: "dbo");

            migrationBuilder.RenameColumn(
                name: "ValorNota",
                schema: "dbo",
                table: "Notas",
                newName: "Descricao");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 10, 45, 28, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 10, 45, 28, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 10, 45, 28, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 10, 45, 28, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Notas",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 10, 45, 28, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 10, 45, 28, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2021, 1, 2, 10, 45, 28, 0, DateTimeKind.Unspecified));
        }
    }
}
