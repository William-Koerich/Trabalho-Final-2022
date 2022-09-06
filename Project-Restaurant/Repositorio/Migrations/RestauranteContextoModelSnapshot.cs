﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositorio.BancoDados;

#nullable disable

namespace Repositorio.Migrations
{
    [DbContext(typeof(RestauranteContexto))]
    partial class RestauranteContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Repositorio.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MesaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MesaId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Repositorio.Entidades.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("NumeroMesa")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Mesa");
                });

            modelBuilder.Entity("Repositorio.Entidades.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("MesaId")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MesaId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Repositorio.Entidades.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("VARCHAR(1000)")
                        .HasColumnName("categoria");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)")
                        .HasColumnName("nome");

                    b.Property<string>("ProdutoCaminho")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("VARCHAR(1000)")
                        .HasColumnName("produto_caminho");

                    b.Property<decimal>("Valor")
                        .HasColumnType("DECIMAL")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.ToTable("produtos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Categoria = "Massas",
                            Descricao = "Yakissoba de frango e legumes",
                            Nome = "Yakissoba",
                            ProdutoCaminho = "favicon.ico",
                            Valor = 20m
                        },
                        new
                        {
                            Id = 2,
                            Categoria = "Bebidas",
                            Descricao = "Coca-cola 600ml",
                            Nome = "Coca-cola 600ml",
                            ProdutoCaminho = "favicon.ico",
                            Valor = 6m
                        });
                });

            modelBuilder.Entity("Repositorio.Entidades.ProdutoPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("INT")
                        .HasColumnName("pedido_id");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("INT")
                        .HasColumnName("produto_id");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("DECIMAL")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("produtos_pedidos", (string)null);
                });

            modelBuilder.Entity("Repositorio.Entidades.Cliente", b =>
                {
                    b.HasOne("Repositorio.Entidades.Mesa", null)
                        .WithMany("Clientes")
                        .HasForeignKey("MesaId");
                });

            modelBuilder.Entity("Repositorio.Entidades.Pedido", b =>
                {
                    b.HasOne("Repositorio.Entidades.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repositorio.Entidades.Mesa", "Mesa")
                        .WithMany("Pedidos")
                        .HasForeignKey("MesaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Mesa");
                });

            modelBuilder.Entity("Repositorio.Entidades.ProdutoPedido", b =>
                {
                    b.HasOne("Repositorio.Entidades.Cliente", null)
                        .WithMany("ProdutosPedidos")
                        .HasForeignKey("ClienteId");

                    b.HasOne("Repositorio.Entidades.Pedido", "Pedido")
                        .WithMany("ProdutosPedidos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repositorio.Entidades.Produto", "Produto")
                        .WithMany("ProdutosPedidos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Repositorio.Entidades.Cliente", b =>
                {
                    b.Navigation("Pedidos");

                    b.Navigation("ProdutosPedidos");
                });

            modelBuilder.Entity("Repositorio.Entidades.Mesa", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Repositorio.Entidades.Pedido", b =>
                {
                    b.Navigation("ProdutosPedidos");
                });

            modelBuilder.Entity("Repositorio.Entidades.Produto", b =>
                {
                    b.Navigation("ProdutosPedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
