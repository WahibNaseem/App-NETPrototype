﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.Migrations
{
  [DbContext(typeof(MessageContext))]
  [Migration("20230325002904_InitialCreate")]
  partial class InitialCreate
  {
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("ProductVersion", "3.1.1");

      modelBuilder.Entity("API.Entities.Message", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<string>("Sender")
                      .HasColumnType("TEXT");

            b.Property<DateTime>("SentDate")
                      .HasColumnType("TEXT");

            b.Property<string>("Text")
                      .HasColumnType("TEXT");

            b.HasKey("Id");

            b.ToTable("Messages");
          });
#pragma warning restore 612, 618
    }
  }
}
