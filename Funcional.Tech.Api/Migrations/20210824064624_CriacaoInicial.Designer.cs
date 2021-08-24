﻿// <auto-generated />
using System;
using Funcional.Tech.Api.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Funcional.Tech.Api.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210824064624_CriacaoInicial")]
    partial class CriacaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Funcional.Tech.Api.Models.Conta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("conta")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("data_criacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("(now())");

                    b.Property<double>("saldo")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("conta","contabancaria");
                });
#pragma warning restore 612, 618
        }
    }
}