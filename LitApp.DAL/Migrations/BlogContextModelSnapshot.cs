﻿// <auto-generated />
using System;
using LitApp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LitChat.DAL.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LitChat.DAL.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PasswordReset")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Verified")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Accounts", (string)null);
                });

            modelBuilder.Entity("LitChat.DAL.Models.ChatMessages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FromEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FromUserId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FromUserId");

                    b.HasIndex("ToUserId");

                    b.ToTable("Messages", (string)null);
                });

            modelBuilder.Entity("LitChat.DAL.Models.Connections", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ConnectedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConnectionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DisconnectedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.Property<int>("UserAccount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserAccount");

                    b.ToTable("Connections", (string)null);
                });

            modelBuilder.Entity("LitChat.DAL.Models.FavoritesList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FavoriteUserAccountId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerAccountId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FavoriteUserAccountId");

                    b.HasIndex("OwnerAccountId");

                    b.ToTable("FavoritesUsers", (string)null);
                });

            modelBuilder.Entity("LitChat.DAL.Models.Friend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("ApprovedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfRejection")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NextRequest")
                        .HasColumnType("datetime2");

                    b.Property<int>("RequestById")
                        .HasColumnType("int");

                    b.Property<int>("RequestFlags")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RequestTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("RequestToId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RequestById");

                    b.HasIndex("RequestToId");

                    b.ToTable("Friends", (string)null);
                });

            modelBuilder.Entity("LitChat.DAL.Models.UserInfo", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("UserInfos", (string)null);
                });

            modelBuilder.Entity("LitChat.DAL.Models.Account", b =>
                {
                    b.OwnsMany("LitChat.DAL.Models.Account.RefreshTokens#LitChat.DAL.Models.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<int>("AccountId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("Created")
                                .HasColumnType("datetime2");

                            b1.Property<string>("CreatedByIp")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("Expires")
                                .HasColumnType("datetime2");

                            b1.Property<string>("ReplacedByToken")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime?>("Revoked")
                                .HasColumnType("datetime2");

                            b1.Property<string>("RevokedByIp")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Token")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("Id");

                            b1.HasIndex("AccountId");

                            b1.ToTable("RefreshToken", (string)null);

                            b1.WithOwner("Account")
                                .HasForeignKey("AccountId");

                            b1.Navigation("Account");
                        });

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("LitChat.DAL.Models.ChatMessages", b =>
                {
                    b.HasOne("LitChat.DAL.Models.Account", "FromUser")
                        .WithMany("MessagesFromUser")
                        .HasForeignKey("FromUserId")
                        .IsRequired();

                    b.HasOne("LitChat.DAL.Models.Account", "ToUser")
                        .WithMany("MessagesToUser")
                        .HasForeignKey("ToUserId")
                        .IsRequired();

                    b.Navigation("FromUser");

                    b.Navigation("ToUser");
                });

            modelBuilder.Entity("LitChat.DAL.Models.Connections", b =>
                {
                    b.HasOne("LitChat.DAL.Models.Account", "Account")
                        .WithMany("Connections")
                        .HasForeignKey("UserAccount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("LitChat.DAL.Models.FavoritesList", b =>
                {
                    b.HasOne("LitChat.DAL.Models.Account", "FavoriteAccount")
                        .WithMany("Favorites")
                        .HasForeignKey("FavoriteUserAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FavoriteAccount");
                });

            modelBuilder.Entity("LitChat.DAL.Models.Friend", b =>
                {
                    b.HasOne("LitChat.DAL.Models.Account", "RequestBy")
                        .WithMany("SentFriendsRequest")
                        .HasForeignKey("RequestById")
                        .IsRequired();

                    b.HasOne("LitChat.DAL.Models.Account", "RequestTo")
                        .WithMany("RecievedFriendRequest")
                        .HasForeignKey("RequestToId")
                        .IsRequired();

                    b.Navigation("RequestBy");

                    b.Navigation("RequestTo");
                });

            modelBuilder.Entity("LitChat.DAL.Models.UserInfo", b =>
                {
                    b.HasOne("LitChat.DAL.Models.Account", "Account")
                        .WithOne("Profile")
                        .HasForeignKey("LitChat.DAL.Models.UserInfo", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("LitChat.DAL.Models.Account", b =>
                {
                    b.Navigation("Connections");

                    b.Navigation("Favorites");

                    b.Navigation("MessagesFromUser");

                    b.Navigation("MessagesToUser");

                    b.Navigation("Profile");

                    b.Navigation("RecievedFriendRequest");

                    b.Navigation("SentFriendsRequest");
                });
#pragma warning restore 612, 618
        }
    }
}
