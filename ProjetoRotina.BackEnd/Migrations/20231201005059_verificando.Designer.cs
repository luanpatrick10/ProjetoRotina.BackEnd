﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProjetoRotina.BackEnd.Repositorio;

#nullable disable

namespace ProjetoRotina.BackEnd.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20231201005059_verificando")]
    partial class verificando
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProjetoRotina.BackEnd.Entidades.Rotina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DiasDaSemana")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("IdDoUsuario")
                        .HasColumnType("integer");

                    b.Property<string>("NomeDaRotina")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RotinaRealizadaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RotinaRealizadaId");

                    b.ToTable("Rotinas");
                });

            modelBuilder.Entity("ProjetoRotina.BackEnd.Entidades.RotinaRealizada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DataDaRealizacao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("IdDaRotina")
                        .HasColumnType("integer");

                    b.Property<bool>("Realizado")
                        .HasColumnType("boolean");

                    b.Property<int?>("RotinaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RotinaId");

                    b.ToTable("RotinaRealizada");
                });

            modelBuilder.Entity("ProjetoRotina.BackEnd.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DataDeNascimento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProjetoRotina.BackEnd.Entidades.Rotina", b =>
                {
                    b.HasOne("ProjetoRotina.BackEnd.Entidades.RotinaRealizada", "RotinaRealizada")
                        .WithMany()
                        .HasForeignKey("RotinaRealizadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RotinaRealizada");
                });

            modelBuilder.Entity("ProjetoRotina.BackEnd.Entidades.RotinaRealizada", b =>
                {
                    b.HasOne("ProjetoRotina.BackEnd.Entidades.Rotina", null)
                        .WithMany("RotinasRealizadas")
                        .HasForeignKey("RotinaId");
                });

            modelBuilder.Entity("ProjetoRotina.BackEnd.Entidades.Rotina", b =>
                {
                    b.Navigation("RotinasRealizadas");
                });
#pragma warning restore 612, 618
        }
    }
}
