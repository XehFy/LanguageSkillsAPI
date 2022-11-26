﻿// <auto-generated />
using System;
using LanguageSkillsAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LanguageSkillsAPI.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20221126123635_UpdateLanguageToString")]
    partial class UpdateLanguageToString
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LanguageSkillsAPI.Data.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Example")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<string>("Word")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("LanguageSkillsAPI.Data.Entities.CardTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CardId")
                        .HasColumnType("integer");

                    b.Property<string>("ExampleTranslation")
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Translate")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("CardTranslations");
                });

            modelBuilder.Entity("LanguageSkillsAPI.Data.Entities.CardTranslation", b =>
                {
                    b.HasOne("LanguageSkillsAPI.Data.Entities.Card", null)
                        .WithMany("cardTranslations")
                        .HasForeignKey("CardId");
                });

            modelBuilder.Entity("LanguageSkillsAPI.Data.Entities.Card", b =>
                {
                    b.Navigation("cardTranslations");
                });
#pragma warning restore 612, 618
        }
    }
}