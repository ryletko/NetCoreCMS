﻿/*************************************************************
 *          Project: NetCoreCMS                              *
 *              Web: http://dotnetcorecms.org                *
 *           Author: OnnoRokom Software Ltd.                 *
 *          Website: www.onnorokomsoftware.com               *
 *            Email: info@onnorokomsoftware.com              *
 *        Copyright: OnnoRokom Software Ltd.                 *
 *          License: BSD-3-Clause                            *
 *************************************************************/

using System;
using System.Linq;
using NetCoreCMS.Framework.Modules.Widgets;
using NetCoreCMS.Framework.Modules;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using NetCoreCMS.Framework.Core.Models;
using NetCoreCMS.Framework.Themes;

using NetCoreCMS.Framework.Setup;
using System.Collections;
using Microsoft.AspNetCore.Http;
using NetCoreCMS.Framework.Core.Mvc.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Reflection;

namespace NetCoreCMS.Framework.Utility
{
    /// <summary>
    /// NetCoreCMS Global Context. This class contains Running WebSite, Theme, Modules and Widgets.
    /// </summary>
    public class GlobalContext
    {
        /// <summary>
        /// WebSite contains running website's basic information like Title, Slogan, Logo Image, Default Language etc.
        /// </summary>
        public static NccWebSite WebSite { get; set; }

        /// <summary>
        /// If from any location of the project set it's value to true for restarting the application
        /// </summary>
        public static bool IsRestartRequired { get; set; }

        /// <summary>
        /// List of all modules are containing at Modules folder inside web project.
        /// </summary>
        public static List<IModule> Modules { get; set; } = new List<IModule>();

        /// <summary>
        /// Website configurations.
        /// </summary>
        public static IConfiguration Configuration { get; set; }

        public static IConfigurationRoot ConfigurationRoot { get; set; }

        /// <summary>
        /// Environment of current hosting.
        /// </summary>
        public static IHostingEnvironment HostingEnvironment { get; set; }

        /// <summary>
        /// Provide class type from string class name.
        /// </summary>
        /// <param name="className">Class contains in modules.</param>
        /// <returns></returns>
        internal static Type GetTypeContainsInModules(string className)
        {
            var activeModules = GetActiveModules();
            foreach (var item in activeModules)
            {
                var type = item.GetType().Assembly.GetType(className);
                if(type != null)
                {
                    return type;
                }
            }
            return null;
        }

        /// <summary>
        /// Widget list of all active modules widget. It populates when modules are loaded.
        /// </summary>
        public static List<Widget> Widgets{ get; set; } = new List<Widget>();
        /// <summary>
        /// List of already placed widgets on different layout zone of theme.
        /// </summary>
        public static List<NccWebSiteWidget> WebSiteWidgets { get; set; } = new List<NccWebSiteWidget>();
        /// <summary>
        /// List of themes contains at Themes folder of web project.
        /// </summary>
        public static List<Theme> Themes { get; set; }

        internal static IModule GetModuleByAssemblyName(AssemblyName assemblyName)
        {
            var module = Modules.Where(x => x.Assembly.GetName().Name == assemblyName.Name).FirstOrDefault();
            return module;
        }

        /// <summary>
        /// List of website menus. Which is created from admin panel for website's different location and language.
        /// </summary>
        public static List<NccMenu> Menus { get; set; }
        /// <summary>
        /// Website setup configuration
        /// </summary>
        public static SetupConfig SetupConfig { get; set; }
        /// <summary>
        /// Web root path of web project. ex. wwwroot
        /// </summary>
        public static string WebRootPath { get; set; }
        /// <summary>
        /// Root location of web project.
        /// </summary>
        public static string ContentRootPath { get; set; }
        /// <summary>
        /// Builded web application instance.
        /// </summary>
        public static IApplicationBuilder App { get; set; }
        //public static Theme ActiveTheme { get; set; }
        
        public string SiteBaseUrl { get; set; }
        public string StartupController { get; set; }

        //public static string CurrentLanguage { get; set; }

        /// <summary>
        /// Return a list of active modules.
        /// </summary>
        /// <returns></returns>
        public static List<IModule> GetActiveModules()
        {
            var query = from m in Modules where m.ModuleStatus == (int) NccModule.NccModuleStatus.Active select m;
            return query.ToList();
        }

        public string StartupAction { get; set; }
        /// <summary>
        /// All registered service and class instance container. Which are used for dependency injection.
        /// </summary>
        public static IServiceCollection Services { get; set; } 
        
        /// <summary>
        /// Short code list of all modules.
        /// </summary>
        public static Hashtable ShortCodes { get; set; }
        /// <summary>
        /// Configured service provider.
        /// </summary>
        public static IServiceProvider ServiceProvider { get; set; }
        /// <summary>
        /// List all widgets of modules.
        /// </summary>
        public static void ListWidgets()
        {
            foreach (var item in Modules)
            {
                Widgets.AddRange(item.Widgets);
            }
        }

        /// <summary>
        /// This method provide logged user ID
        /// </summary>
        /// <returns>retuns long id</returns>
        public static long GetCurrentUserId()
        {
            HttpContextAccessor hca = new HttpContextAccessor();
            long? userId = hca.HttpContext?.User?.GetUserId();
            if (userId == null)
                return 0;
            return userId.Value;
        }

        /// <summary>
        /// Method for getting theme by the name.
        /// </summary>
        /// <param name="themeName"> Theme name which is same as folder name.</param>
        /// <returns>Return the theme object.</returns>
        public static Theme GetThemeByName(string themeName)
        {
            return Themes.Where(x => x.ThemeName == themeName).FirstOrDefault();
        } 

        /// <summary>
        /// Provides currently logged user's name.
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentUserName()
        {
            HttpContextAccessor hca = new HttpContextAccessor();
            string userName = hca.HttpContext?.User?.Identity.Name;
            return userName;
        }

        /// <summary>
        /// Method for getting loaded module by Module ID
        /// </summary>
        /// <param name="moduleId">Id which contains at Module.json config file</param>
        /// <returns>Module instance</returns>
        public static IModule GetModuleByModuleId(string moduleId)
        {
            return Modules.Where(x => x.ModuleId == moduleId).FirstOrDefault();
        }
    }
}