using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.EnsureSchema(
            //    name: "dbo");

            //migrationBuilder.CreateTable(
            //    name: "Notas",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Descricao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        Disponivel = table.Column<bool>(type: "bit", nullable: false),
            //        DataCadastro = table.Column<DateTime>(type: "Datetime", nullable: false),
            //        Ativo = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Notas", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Saque",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CodigoSaque = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        DataSaque = table.Column<DateTime>(type: "Datetime", nullable: false),
            //        DataCadastro = table.Column<DateTime>(type: "Datetime", nullable: false),
            //        Ativo = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Saque", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TipoCliente",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Sigla = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Ativo = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TipoCliente", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Cliente",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CpfCnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        TipoClienteId = table.Column<int>(type: "int", nullable: false),
            //        DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Ativo = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Cliente", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Cliente_TipoCliente_TipoClienteId",
            //            column: x => x.TipoClienteId,
            //            principalSchema: "dbo",
            //            principalTable: "TipoCliente",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CaixaEletronica",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        QuantidadeNotas = table.Column<int>(type: "int", nullable: false),
            //        NotasId = table.Column<int>(type: "int", nullable: false),
            //        ClienteId = table.Column<int>(type: "int", nullable: false),
            //        DataCadastro = table.Column<DateTime>(type: "Datetime", nullable: false),
            //        Ativo = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CaixaEletronica", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_CaixaEletronica_Cliente_ClienteId",
            //            column: x => x.ClienteId,
            //            principalSchema: "dbo",
            //            principalTable: "Cliente",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_CaixaEletronica_Notas_NotasId",
            //            column: x => x.NotasId,
            //            principalSchema: "dbo",
            //            principalTable: "Notas",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CaixaEletronicaSaque",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        CaixaEletronicaId = table.Column<int>(type: "int", nullable: false),
            //        SaqueId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CaixaEletronicaSaque", x => new { x.CaixaEletronicaId, x.SaqueId });
            //        table.ForeignKey(
            //            name: "FK_CaixaEletronicaSaque_CaixaEletronica_CaixaEletronicaId",
            //            column: x => x.CaixaEletronicaId,
            //            principalSchema: "dbo",
            //            principalTable: "CaixaEletronica",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_CaixaEletronicaSaque_Saque_SaqueId",
            //            column: x => x.SaqueId,
            //            principalSchema: "dbo",
            //            principalTable: "Saque",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.InsertData(
            //    schema: "dbo",
            //    table: "TipoCliente",
            //    columns: new[] { "Id", "Ativo", "DataCadastro", "Nome", "Sigla" },
            //    values: new object[] { 1, true, new DateTime(2021, 1, 2, 10, 15, 59, 0, DateTimeKind.Unspecified), "Pessoa Fisica", "PF" });

            //migrationBuilder.InsertData(
            //    schema: "dbo",
            //    table: "TipoCliente",
            //    columns: new[] { "Id", "Ativo", "DataCadastro", "Nome", "Sigla" },
            //    values: new object[] { 2, true, new DateTime(2021, 1, 2, 10, 15, 59, 0, DateTimeKind.Unspecified), "Pessoa Juridica", "PJ" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_CaixaEletronica_ClienteId",
            //    schema: "dbo",
            //    table: "CaixaEletronica",
            //    column: "ClienteId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CaixaEletronica_NotasId",
            //    schema: "dbo",
            //    table: "CaixaEletronica",
            //    column: "NotasId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CaixaEletronicaSaque_SaqueId",
            //    schema: "dbo",
            //    table: "CaixaEletronicaSaque",
            //    column: "SaqueId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cliente_TipoClienteId",
            //    schema: "dbo",
            //    table: "Cliente",
            //    column: "TipoClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaixaEletronicaSaque",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CaixaEletronica",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Saque",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Cliente",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Notas",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TipoCliente",
                schema: "dbo");
        }
    }
}
