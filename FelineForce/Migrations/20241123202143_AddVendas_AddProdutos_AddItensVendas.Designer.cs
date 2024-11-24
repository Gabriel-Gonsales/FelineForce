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
    [Migration("20241123202143_AddVendas_AddProdutos_AddItensVendas")]
    partial class AddVendas_AddProdutos_AddItensVendas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

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

            modelBuilder.Entity("FelineForce.Models.Atendimento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Alteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataAtendimento")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid?>("GatoId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Inclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("GatoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Atendimentos");
                });

            modelBuilder.Entity("FelineForce.Models.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Alteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Inclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("FelineForce.Models.Gato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Alteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("char(36)");

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

                    b.HasIndex("ClienteId");

                    b.HasIndex("TutorId");

                    b.ToTable("Gatos");
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

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("Excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Inclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("FelineForce.Models.Atendimento", b =>
                {
                    b.HasOne("FelineForce.Models.Cliente", null)
                        .WithMany("Atendimentos")
                        .HasForeignKey("ClienteId");

                    b.HasOne("FelineForce.Models.Gato", null)
                        .WithMany("Atendimentos")
                        .HasForeignKey("GatoId");

                    b.HasOne("FelineForce.Models.Usuario", null)
                        .WithMany("Atendimentos")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("FelineForce.Models.Gato", b =>
                {
                    b.HasOne("FelineForce.Models.Cliente", null)
                        .WithMany("Gatos")
                        .HasForeignKey("ClienteId");

                    b.HasOne("FelineForce.Models.Usuario", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tutor");
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

            modelBuilder.Entity("FelineForce.Models.Gato", b =>
                {
                    b.Navigation("Atendimentos");
                });

            modelBuilder.Entity("FelineForce.Models.Produto", b =>
                {
                    b.Navigation("ItensVenda");
                });

            modelBuilder.Entity("FelineForce.Models.Usuario", b =>
                {
                    b.Navigation("Atendimentos");

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
