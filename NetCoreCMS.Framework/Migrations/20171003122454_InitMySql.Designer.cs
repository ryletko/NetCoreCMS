﻿/*************************************************************
 *          Project: NetCoreCMS                              *
 *              Web: http://dotnetcorecms.org                *
 *           Author: OnnoRokom Software Ltd.                 *
 *          Website: www.onnorokomsoftware.com               *
 *            Email: info@onnorokomsoftware.com              *
 *        Copyright: OnnoRokom Software Ltd.                 *
 *          License: BSD-3-Clause                            *
 *************************************************************/

// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using NetCoreCMS.Framework.Core.Data;
using NetCoreCMS.Framework.Core.Models;
using System;

namespace NetCoreCMS.Framework.Migrations
{
    [DbContext(typeof(NccDbContext))]
    [Migration("20171003122454_InitMySql")]
    partial class InitMySql
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<long>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Ncc_Role_Claim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<long?>("NccUserId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("NccUserId");

                    b.HasIndex("UserId");

                    b.ToTable("Ncc_User_Claim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<long?>("NccUserId");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<long>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("NccUserId");

                    b.HasIndex("UserId");

                    b.ToTable("Ncc_User_Login");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("Ncc_User_Token");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryImage");

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<long?>("ParentId");

                    b.Property<int>("Status");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Ncc_Category");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccCategoryDetails", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("CategoryId");

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Language");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeyword");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<string>("Slug");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Ncc_Category_Details");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccComment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AuthorId");

                    b.Property<string>("Content");

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<long?>("PostId");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostId");

                    b.ToTable("Ncc_Post_Comment");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccMenu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("MenuIconCls");

                    b.Property<string>("MenuLanguage");

                    b.Property<int>("MenuOrder");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<string>("Position");

                    b.Property<int>("Status");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.ToTable("Ncc_Menu");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccMenuItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<string>("Controller");

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Data");

                    b.Property<int>("MenuActionType");

                    b.Property<int>("MenuFor");

                    b.Property<string>("MenuIconCls");

                    b.Property<int>("MenuOrder");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Module");

                    b.Property<string>("Name");

                    b.Property<long?>("NccMenuId");

                    b.Property<long?>("NccMenuItemId");

                    b.Property<long?>("NccMenuItemId1");

                    b.Property<long?>("ParentId");

                    b.Property<int>("Position");

                    b.Property<int>("Status");

                    b.Property<string>("Target");

                    b.Property<string>("Url");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("NccMenuId");

                    b.HasIndex("NccMenuItemId");

                    b.HasIndex("NccMenuItemId1");

                    b.HasIndex("ParentId");

                    b.ToTable("Ncc_Menu_Item");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccModule", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AntiForgery");

                    b.Property<string>("Author");

                    b.Property<string>("Category");

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<string>("Folder");

                    b.Property<string>("MaxNccVersion");

                    b.Property<string>("Metadata");

                    b.Property<string>("MinNccVersion");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("ModuleId");

                    b.Property<int>("ModuleStatus");

                    b.Property<string>("ModuleTitle");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.Property<int>("Status");

                    b.Property<string>("Version");

                    b.Property<int>("VersionNumber");

                    b.Property<string>("WebSite");

                    b.HasKey("Id");

                    b.ToTable("Ncc_Module");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccModuleDependency", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("MaxVersion");

                    b.Property<string>("Metadata");

                    b.Property<string>("MinVersion");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("ModuleId");

                    b.Property<string>("Name");

                    b.Property<long?>("NccModuleId");

                    b.Property<int>("Status");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("NccModuleId");

                    b.ToTable("Ncc_Module_Dependency");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccPage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Layout");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<int>("PageOrder");

                    b.Property<int>("PageStatus");

                    b.Property<int>("PageType");

                    b.Property<long?>("ParentId");

                    b.Property<DateTime>("PublishDate");

                    b.Property<int>("Status");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Ncc_Page");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccPageDetails", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .HasMaxLength(2147483647);

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Language");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeyword");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<long?>("PageId");

                    b.Property<string>("Slug");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.ToTable("Ncc_Page_Details");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccPlugins", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AntiForgery");

                    b.Property<string>("Author");

                    b.Property<string>("Category");

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Dependencies");

                    b.Property<string>("Description");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<string>("NetCoreCMSVersion");

                    b.Property<string>("Path");

                    b.Property<int>("PluginsStatus");

                    b.Property<string>("SortName");

                    b.Property<int>("Status");

                    b.Property<string>("Version");

                    b.Property<int>("VersionNumber");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.ToTable("Ncc_Plugins");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccPost", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AllowComment");

                    b.Property<long?>("AuthorId");

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<bool>("IsFeatured");

                    b.Property<bool>("IsStiky");

                    b.Property<string>("Layout");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<long?>("ParentId");

                    b.Property<int>("PostStatus");

                    b.Property<int>("PostType");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("RelatedPosts");

                    b.Property<int>("Status");

                    b.Property<string>("ThumImage");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ParentId");

                    b.ToTable("Ncc_Post");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccPostCategory", b =>
                {
                    b.Property<long>("PostId");

                    b.Property<long>("CategoryId");

                    b.HasKey("PostId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Ncc_Post_Category");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccPostDetails", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Language");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeyword");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<long?>("PostId");

                    b.Property<string>("Slug");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Ncc_Post_Details");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccPostTag", b =>
                {
                    b.Property<long>("PostId");

                    b.Property<long>("TagId");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("Ncc_Post_Tag");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.Property<string>("Slug");

                    b.Property<int>("Status");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Ncc_Role");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccSettings", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("GroupId");

                    b.Property<string>("Key");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.Property<string>("Value");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.ToTable("Ncc_Settings");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccStartup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<long>("RoleId");

                    b.Property<int>("StartupFor");

                    b.Property<int>("StartupType");

                    b.Property<string>("StartupUrl");

                    b.Property<int>("Status");

                    b.Property<long>("UserId");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Ncc_Startup");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccTag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.ToTable("Ncc_Tag");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Metadata");

                    b.Property<string>("Mobile");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Slug");

                    b.Property<int>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("Ncc_User");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccUserRole", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<long>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("Ncc_User_Role");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccWebSite", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AllowRegistration");

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("DateFormat");

                    b.Property<string>("DomainName");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("GoogleAnalyticsId");

                    b.Property<bool>("IsMultiLangual");

                    b.Property<bool>("IsShowFullPost");

                    b.Property<string>("Language");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<string>("NewUserRole");

                    b.Property<int>("PerPagePostSize");

                    b.Property<int>("Status");

                    b.Property<string>("TimeFormat");

                    b.Property<string>("TimeZone");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.ToTable("Ncc_WebSite");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccWebSiteInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Copyrights");

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("FaviconUrl");

                    b.Property<string>("Language");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<long?>("NccWebSiteId");

                    b.Property<string>("PrivacyPolicyUrl");

                    b.Property<string>("SiteLogoUrl");

                    b.Property<string>("SiteTitle");

                    b.Property<int>("Status");

                    b.Property<string>("Tagline");

                    b.Property<string>("TermsAndConditionsUrl");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("NccWebSiteId");

                    b.ToTable("Ncc_WebSite_Info");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccWebSiteWidget", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("LayoutName");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("ModuleId");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.Property<string>("ThemeId");

                    b.Property<int>("VersionNumber");

                    b.Property<long?>("WebSiteId");

                    b.Property<string>("WidgetConfigJson");

                    b.Property<string>("WidgetData");

                    b.Property<string>("WidgetId");

                    b.Property<int>("WidgetOrder");

                    b.Property<string>("Zone");

                    b.HasKey("Id");

                    b.HasIndex("WebSiteId");

                    b.ToTable("Ncc_WebSite_Widget");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccWidget", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Content");

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Dependencies");

                    b.Property<string>("Description");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<long?>("NccPluginsId");

                    b.Property<string>("NetCoreCMSVersion");

                    b.Property<string>("SortName");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("NccPluginsId");

                    b.ToTable("Ncc_Widget");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccWidgetSection", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Dependencies");

                    b.Property<string>("Description");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name");

                    b.Property<string>("NetCoreCMSVersion");

                    b.Property<string>("SortName");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.ToTable("Ncc_Widget_Sections");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccUser")
                        .WithMany("Claims")
                        .HasForeignKey("NccUserId");

                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccUser")
                        .WithMany("Logins")
                        .HasForeignKey("NccUserId");

                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccCategory", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccCategory", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccCategoryDetails", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccCategory", "Category")
                        .WithMany("CategoryDetails")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccComment", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccPost", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccMenuItem", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccMenu")
                        .WithMany("MenuItems")
                        .HasForeignKey("NccMenuId");

                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccMenuItem")
                        .WithMany("SubActions")
                        .HasForeignKey("NccMenuItemId");

                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccMenuItem")
                        .WithMany("Childrens")
                        .HasForeignKey("NccMenuItemId1");

                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccMenuItem", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccModuleDependency", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccModule")
                        .WithMany("Dependencies")
                        .HasForeignKey("NccModuleId");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccPage", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccPage", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccPageDetails", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccPage", "Page")
                        .WithMany("PageDetails")
                        .HasForeignKey("PageId");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccPost", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccPost", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccPostCategory", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccCategory", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccPost", "Post")
                        .WithMany("Categories")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccPostDetails", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccPost", "Post")
                        .WithMany("PostDetails")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccPostTag", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccPost", "Post")
                        .WithMany("Tags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccTag", "Tag")
                        .WithMany("Posts")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccStartup", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccUserRole", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccRole", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccUser", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccWebSiteInfo", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccWebSite")
                        .WithMany("WebSiteInfos")
                        .HasForeignKey("NccWebSiteId");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccWebSiteWidget", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccWebSite", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteId");
                });

            modelBuilder.Entity("NetCoreCMS.Framework.Core.Models.NccWidget", b =>
                {
                    b.HasOne("NetCoreCMS.Framework.Core.Models.NccPlugins")
                        .WithMany("Widgets")
                        .HasForeignKey("NccPluginsId");
                });
#pragma warning restore 612, 618
        }
    }
}
