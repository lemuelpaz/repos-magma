﻿// <auto-generated />
using System;
using Magma3.NotaFiscal.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Magma3.NotaFiscal.Infra.Data.Migrations
{
    [DbContext(typeof(NotaFiscalDbContext))]
    partial class NotaFiscalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Magma3.NotaFiscal.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_cliente");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome_cliente");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_cliente");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("tb_cliente", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NomeCliente = "Cliente 1",
                            UId = new Guid("e6b4c469-6d09-4181-8af4-50251113052f")
                        },
                        new
                        {
                            Id = 2,
                            NomeCliente = "Cliente 2",
                            UId = new Guid("f20eda52-1e24-4bee-96fd-e3fe01afe650")
                        },
                        new
                        {
                            Id = 3,
                            NomeCliente = "Cliente 3",
                            UId = new Guid("eea7d355-9a0a-4a3f-a52d-609fe01e0f60")
                        });
                });

            modelBuilder.Entity("Magma3.NotaFiscal.Domain.Entities.NotaFiscal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_nota_fiscal");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ChaveAcesso")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("chave_acesso_nota_fiscal");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_cliente");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnType("datetime")
                        .HasColumnName("data_emissao_nota_fiscal");

                    b.Property<string>("NumeroNota")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("numero_nota_fiscal");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_nota_fiscal");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("ClienteId");

                    b.ToTable("tb_nota_fiscal", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChaveAcesso = "84815641816",
                            ClienteId = 1,
                            DataEmissao = new DateTime(2023, 4, 29, 22, 4, 23, 0, DateTimeKind.Local).AddTicks(891),
                            NumeroNota = "12346578415",
                            UId = new Guid("b276c5d2-6e12-47d6-9e9f-c08e763224f9")
                        },
                        new
                        {
                            Id = 2,
                            ChaveAcesso = "32433241816",
                            ClienteId = 2,
                            DataEmissao = new DateTime(2023, 4, 29, 22, 4, 23, 0, DateTimeKind.Local).AddTicks(905),
                            NumeroNota = "12346578415",
                            UId = new Guid("09b5bc1f-204a-4c7e-85d2-1c81086e31b6")
                        },
                        new
                        {
                            Id = 3,
                            ChaveAcesso = "67545634636",
                            ClienteId = 3,
                            DataEmissao = new DateTime(2023, 4, 29, 22, 4, 23, 0, DateTimeKind.Local).AddTicks(906),
                            NumeroNota = "12341231231",
                            UId = new Guid("fd9fd30e-4044-49eb-a0ce-dea3bb3cce3f")
                        });
                });

            modelBuilder.Entity("Magma3.NotaFiscal.Domain.Entities.NotaFiscalProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_nota_fiscal_produto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime")
                        .HasColumnName("data_compra_produto");

                    b.Property<int>("NotaFiscalId")
                        .HasColumnType("int")
                        .HasColumnName("fk_nota_fiscal");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int")
                        .HasColumnName("fk_produto");

                    b.Property<decimal>("ProdutoPreco")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("preco_produto");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_nota_fiscal_produto");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("NotaFiscalId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("tb_nota_fiscal_produto", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataCompra = new DateTime(2023, 4, 29, 22, 4, 23, 0, DateTimeKind.Local).AddTicks(3137),
                            NotaFiscalId = 1,
                            ProdutoId = 1,
                            ProdutoPreco = 99.99m,
                            UId = new Guid("245a557a-adf9-40dd-9427-bcf5ca51429b")
                        },
                        new
                        {
                            Id = 2,
                            DataCompra = new DateTime(2023, 4, 29, 22, 4, 23, 0, DateTimeKind.Local).AddTicks(3148),
                            NotaFiscalId = 2,
                            ProdutoId = 2,
                            ProdutoPreco = 55.99m,
                            UId = new Guid("81039b0e-e786-49ec-ae45-d2286a89797b")
                        },
                        new
                        {
                            Id = 3,
                            DataCompra = new DateTime(2023, 4, 29, 22, 4, 23, 0, DateTimeKind.Local).AddTicks(3155),
                            NotaFiscalId = 3,
                            ProdutoId = 3,
                            ProdutoPreco = 88.00m,
                            UId = new Guid("70854145-b50d-47f1-ba71-a2148eedd18d")
                        });
                });

            modelBuilder.Entity("Magma3.NotaFiscal.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_produto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("des_produto");

                    b.Property<decimal>("ProdutoPreco")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("preco_produto");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_produto");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("tb_produto", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Produto Teste 1",
                            ProdutoPreco = 99.99m,
                            UId = new Guid("80a49885-ec96-4343-b2d0-89390c863359")
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Produto Teste 2",
                            ProdutoPreco = 55.99m,
                            UId = new Guid("40d70913-d22c-4daa-b1e6-04d46cff8d04")
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Produto Teste 3",
                            ProdutoPreco = 88.00m,
                            UId = new Guid("32ce4fa5-6f2a-43f0-b3a8-9fc4ca8eda9f")
                        });
                });

            modelBuilder.Entity("Magma3.NotaFiscal.Domain.ValueObjects.Celular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_celular");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CelularNumero")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("celular_numero");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_cliente");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("tb_celular", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CelularNumero = "51998915689",
                            ClienteId = 1
                        },
                        new
                        {
                            Id = 2,
                            CelularNumero = "51995674356",
                            ClienteId = 2
                        },
                        new
                        {
                            Id = 3,
                            CelularNumero = "51876785678",
                            ClienteId = 3
                        });
                });

            modelBuilder.Entity("Magma3.NotaFiscal.Domain.ValueObjects.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_endereco");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(70)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(70)")
                        .HasColumnName("cidade");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_cliente");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("endereco_numero");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("char(2)")
                        .HasColumnName("uf");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("tb_endereco", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bairro = "Centro Histórico",
                            Cep = "900200004",
                            Cidade = "PORTO ALEGRE",
                            ClienteId = 1,
                            Logradouro = "Rua dos Andradas",
                            Numero = "771",
                            UF = "RS"
                        },
                        new
                        {
                            Id = 2,
                            Bairro = "Centro Histórico",
                            Cep = "900200004",
                            Cidade = "PORTO ALEGRE",
                            ClienteId = 2,
                            Logradouro = "Rua dos Andradas",
                            Numero = "234",
                            UF = "RS"
                        },
                        new
                        {
                            Id = 3,
                            Bairro = "Centro Histórico",
                            Cep = "900200004",
                            Cidade = "PORTO ALEGRE",
                            ClienteId = 3,
                            Logradouro = "Rua dos Andradas",
                            Numero = "534",
                            UF = "RS"
                        });
                });

            modelBuilder.Entity("Magma3.NotaFiscal.Domain.Entities.NotaFiscal", b =>
                {
                    b.HasOne("Magma3.NotaFiscal.Domain.Entities.Cliente", "Cliente")
                        .WithMany("NotaFiscais")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Magma3.NotaFiscal.Domain.Entities.NotaFiscalProduto", b =>
                {
                    b.HasOne("Magma3.NotaFiscal.Domain.Entities.NotaFiscal", "NotaFiscal")
                        .WithMany("Produtos")
                        .HasForeignKey("NotaFiscalId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Magma3.NotaFiscal.Domain.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("NotaFiscal");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Magma3.NotaFiscal.Domain.ValueObjects.Celular", b =>
                {
                    b.HasOne("Magma3.NotaFiscal.Domain.Entities.Cliente", "Cliente")
                        .WithOne("Celular")
                        .HasForeignKey("Magma3.NotaFiscal.Domain.ValueObjects.Celular", "ClienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Magma3.NotaFiscal.Domain.ValueObjects.Endereco", b =>
                {
                    b.HasOne("Magma3.NotaFiscal.Domain.Entities.Cliente", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("Magma3.NotaFiscal.Domain.ValueObjects.Endereco", "ClienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Magma3.NotaFiscal.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Celular");

                    b.Navigation("Endereco");

                    b.Navigation("NotaFiscais");
                });

            modelBuilder.Entity("Magma3.NotaFiscal.Domain.Entities.NotaFiscal", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
