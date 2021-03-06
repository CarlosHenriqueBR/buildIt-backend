﻿// <auto-generated />
using System;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infra.Data.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20210102190429_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CaixaEletronicaSaque", b =>
                {
                    b.Property<int>("CaixaEletronicaId")
                        .HasColumnType("int");

                    b.Property<int>("SaqueId")
                        .HasColumnType("int");

                    b.HasKey("CaixaEletronicaId", "SaqueId");

                    b.HasIndex("SaqueId");

                    b.ToTable("CaixaEletronicaSaque");
                });

            modelBuilder.Entity("Domain.Entidades.CaixaEletronica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("Datetime");

                    b.Property<int>("NotasId")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeNotas")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("NotasId");

                    b.ToTable("CaixaEletronica");
                });

            modelBuilder.Entity("Domain.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoClienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Domain.Entidades.Notas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<decimal>("ValorNota")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Notas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataCadastro = new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified),
                            Disponivel = true,
                            ValorNota = 5m
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataCadastro = new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified),
                            Disponivel = true,
                            ValorNota = 10m
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataCadastro = new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified),
                            Disponivel = true,
                            ValorNota = 20m
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataCadastro = new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified),
                            Disponivel = true,
                            ValorNota = 50m
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataCadastro = new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified),
                            Disponivel = true,
                            ValorNota = 100m
                        });
                });

            modelBuilder.Entity("Domain.Entidades.NotasSugerida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("Datetime");

                    b.Property<int>("NotasId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorNotaSugerida")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("NotasId");

                    b.ToTable("NotasSugerida");
                });

            modelBuilder.Entity("Domain.Entidades.Saque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<Guid>("CodigoSaque")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("Datetime");

                    b.Property<DateTime>("DataSaque")
                        .HasColumnType("Datetime");

                    b.HasKey("Id");

                    b.ToTable("Saque");
                });

            modelBuilder.Entity("Domain.Entidades.TipoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sigla")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoCliente");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataCadastro = new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified),
                            Nome = "Pessoa Fisica",
                            Sigla = "PF"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataCadastro = new DateTime(2021, 1, 2, 16, 4, 28, 0, DateTimeKind.Unspecified),
                            Nome = "Pessoa Juridica",
                            Sigla = "PJ"
                        });
                });

            modelBuilder.Entity("CaixaEletronicaSaque", b =>
                {
                    b.HasOne("Domain.Entidades.CaixaEletronica", null)
                        .WithMany()
                        .HasForeignKey("CaixaEletronicaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entidades.Saque", null)
                        .WithMany()
                        .HasForeignKey("SaqueId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entidades.CaixaEletronica", b =>
                {
                    b.HasOne("Domain.Entidades.Cliente", "Cliente")
                        .WithMany("CaixaEletronica")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entidades.Notas", "Notas")
                        .WithMany("CaixaEletronicas")
                        .HasForeignKey("NotasId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Notas");
                });

            modelBuilder.Entity("Domain.Entidades.Cliente", b =>
                {
                    b.HasOne("Domain.Entidades.TipoCliente", "TipoCliente")
                        .WithMany()
                        .HasForeignKey("TipoClienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("TipoCliente");
                });

            modelBuilder.Entity("Domain.Entidades.NotasSugerida", b =>
                {
                    b.HasOne("Domain.Entidades.Notas", "Notas")
                        .WithMany("NotasSugeridas")
                        .HasForeignKey("NotasId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Notas");
                });

            modelBuilder.Entity("Domain.Entidades.Cliente", b =>
                {
                    b.Navigation("CaixaEletronica");
                });

            modelBuilder.Entity("Domain.Entidades.Notas", b =>
                {
                    b.Navigation("CaixaEletronicas");

                    b.Navigation("NotasSugeridas");
                });
#pragma warning restore 612, 618
        }
    }
}
