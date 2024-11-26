﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FelineForce.Migrations
{
    [DbContext(typeof(FelineForceContext))]
    [Migration("20241125220838_addColumnsVenda")]
    partial class addColumnsVenda
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("FelineForce.Models.Atendimento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Alteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("AtendenteId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataAtendimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<bool>("Excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("GatoId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Inclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<Guid>("TutorId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("AtendenteId");

                    b.HasIndex("GatoId");

                    b.HasIndex("TutorId");

                    b.ToTable("Atendimentos");
                });

            modelBuilder.Entity("FelineForce.Models.ClasseTeste", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Testes");
                });

            modelBuilder.Entity("FelineForce.Models.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Alteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext");

                    b.Property<bool>("Excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Inclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("FelineForce.Models.Compra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Alteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Inclusao")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("FelineForce.Models.Gato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Alteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Inclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("TutorId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("TutorId");

                    b.ToTable("Gatos");
                });

            modelBuilder.Entity("FelineForce.Models.ItemCompra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Alteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CompraId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("Excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Inclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItensCompra");
                });

            modelBuilder.Entity("FelineForce.Models.ItemVenda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Alteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Inclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<Guid?>("VendaId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("VendaId");

                    b.ToTable("ItensVenda");
                });

            modelBuilder.Entity("FelineForce.Models.LogSistema", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Alteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Inclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("FelineForce.Models.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Alteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Inclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Preco")
                        .HasColumnType("float");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("FelineForce.Models.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Alteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Bloqueado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Inclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("FelineForce.Models.Venda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Alteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CPFCliente")
                        .HasColumnType("longtext");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("Excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Inclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("TotalCompra")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("FelineForce.Models.Atendimento", b =>
                {
                    b.HasOne("FelineForce.Models.Usuario", "Atendente")
                        .WithMany("Atendimentos")
                        .HasForeignKey("AtendenteId");

                    b.HasOne("FelineForce.Models.Gato", "Gato")
                        .WithMany("Atendimentos")
                        .HasForeignKey("GatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FelineForce.Models.Cliente", "Tutor")
                        .WithMany("Atendimentos")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atendente");

                    b.Navigation("Gato");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("FelineForce.Models.Gato", b =>
                {
                    b.HasOne("FelineForce.Models.Cliente", "Tutor")
                        .WithMany("Gatos")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("FelineForce.Models.ItemCompra", b =>
                {
                    b.HasOne("FelineForce.Models.Compra", null)
                        .WithMany("Itens")
                        .HasForeignKey("CompraId");

                    b.HasOne("FelineForce.Models.Produto", null)
                        .WithMany("ItensCompra")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("FelineForce.Models.ItemVenda", b =>
                {
                    b.HasOne("FelineForce.Models.Produto", null)
                        .WithMany("ItensVenda")
                        .HasForeignKey("ProdutoId");

                    b.HasOne("FelineForce.Models.Venda", null)
                        .WithMany("Itens")
                        .HasForeignKey("VendaId");
                });

            modelBuilder.Entity("FelineForce.Models.LogSistema", b =>
                {
                    b.HasOne("FelineForce.Models.Usuario", null)
                        .WithMany("Logs")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("FelineForce.Models.Venda", b =>
                {
                    b.HasOne("FelineForce.Models.Cliente", null)
                        .WithMany("Vendas")
                        .HasForeignKey("ClienteId");

                    b.HasOne("FelineForce.Models.Usuario", null)
                        .WithMany("Vendas")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("FelineForce.Models.Cliente", b =>
                {
                    b.Navigation("Atendimentos");

                    b.Navigation("Gatos");

                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("FelineForce.Models.Compra", b =>
                {
                    b.Navigation("Itens");
                });

            modelBuilder.Entity("FelineForce.Models.Gato", b =>
                {
                    b.Navigation("Atendimentos");
                });

            modelBuilder.Entity("FelineForce.Models.Produto", b =>
                {
                    b.Navigation("ItensCompra");

                    b.Navigation("ItensVenda");
                });

            modelBuilder.Entity("FelineForce.Models.Usuario", b =>
                {
                    b.Navigation("Atendimentos");

                    b.Navigation("Logs");

                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("FelineForce.Models.Venda", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}
