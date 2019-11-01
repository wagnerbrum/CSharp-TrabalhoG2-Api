﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Proj.Repository.Data;

namespace Proj.Repository.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191101071814_TableContaLuzAddIdImovel")]
    partial class TableContaLuzAddIdImovel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Proj.Domain.Entities.ContaLuz", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dataLeitura");

                    b.Property<DateTime>("dataPagamento");

                    b.Property<int>("idimovel");

                    b.Property<int?>("imovelid");

                    b.Property<int>("kwGasto");

                    b.Property<double>("mediaConsumo");

                    b.Property<double>("valorAPagar");

                    b.HasKey("id");

                    b.HasIndex("imovelid");

                    b.ToTable("ContasLuz");
                });

            modelBuilder.Entity("Proj.Domain.Entities.Imovel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("bairro");

                    b.Property<string>("cidade");

                    b.Property<string>("estado");

                    b.Property<string>("identificacao");

                    b.Property<string>("numero");

                    b.HasKey("id");

                    b.ToTable("Imoveis");
                });

            modelBuilder.Entity("Proj.Domain.Entities.ContaLuz", b =>
                {
                    b.HasOne("Proj.Domain.Entities.Imovel", "imovel")
                        .WithMany("contasLuz")
                        .HasForeignKey("imovelid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
