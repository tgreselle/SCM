﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SCM.Infrastructure.Data;

namespace SCM.Infrastructure.Migrations
{
    [DbContext(typeof(SCMContext))]
    partial class SCMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SCM.AplicationCore.Entity.Multa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Pontuacao");

                    b.Property<decimal>("Valor");

                    b.Property<int?>("VeiculoId");

                    b.HasKey("Id");

                    b.HasIndex("VeiculoId");

                    b.ToTable("TbInfracao");
                });

            modelBuilder.Entity("SCM.AplicationCore.Entity.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Placa");

                    b.Property<int>("Renavam");

                    b.HasKey("Id");

                    b.ToTable("TbVeiculo");
                });

            modelBuilder.Entity("SCM.AplicationCore.Entity.Multa", b =>
                {
                    b.HasOne("SCM.AplicationCore.Entity.Veiculo", "Veiculo")
                        .WithMany("Multas")
                        .HasForeignKey("VeiculoId");
                });
#pragma warning restore 612, 618
        }
    }
}
