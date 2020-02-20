﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Service.WalletManager.Repositories.DbContexts;

namespace Service.WalletManager.Repositories.Migrations
{
    [DbContext(typeof(WalletManagerContext))]
    [Migration("20200220153945_AddedOriginalWalletColumns")]
    partial class AddedOriginalWalletColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("wallet_manager")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Service.WalletManager.Repositories.Entities.EnrolledBalanceEntity", b =>
                {
                    b.Property<string>("BlockchianId")
                        .HasColumnType("text");

                    b.Property<string>("BlockchainAssetId")
                        .HasColumnType("text");

                    b.Property<string>("WalletAddress")
                        .HasColumnType("text");

                    b.Property<string>("Balance")
                        .HasColumnType("text");

                    b.Property<long>("BlockNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("OriginalWalletAddress")
                        .HasColumnType("text");

                    b.HasKey("BlockchianId", "BlockchainAssetId", "WalletAddress");

                    b.ToTable("enrolled_balance");
                });

            modelBuilder.Entity("Service.WalletManager.Repositories.Entities.OperationEntity", b =>
                {
                    b.Property<string>("BlockchianId")
                        .HasColumnType("text");

                    b.Property<string>("BlockchainAssetId")
                        .HasColumnType("text");

                    b.Property<string>("WalletAddress")
                        .HasColumnType("text");

                    b.Property<long>("OperationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BalanceChange")
                        .HasColumnType("text");

                    b.Property<long>("BlockNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("OriginalWalletAddress")
                        .HasColumnType("text");

                    b.HasKey("BlockchianId", "BlockchainAssetId", "WalletAddress", "OperationId");

                    b.ToTable("operations");
                });
#pragma warning restore 612, 618
        }
    }
}
