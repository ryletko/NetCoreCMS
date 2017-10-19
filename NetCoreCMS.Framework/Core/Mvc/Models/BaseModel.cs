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
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using NetCoreCMS.Framework.Core.Mvc.Extensions;

namespace NetCoreCMS.Framework.Core.Mvc.Models
{
    public class BaseModel : ValidateableModel, IBaseModel<long>
    {
        public BaseModel()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
            CreateBy = ModifyBy = GetCurrentUserId();
            Status = EntityStatus.Active;
            VersionNumber = 1;
            Metadata = "";
            Name = "";
        }

        [Key]
        public long Id { get; set; }
        public int VersionNumber { get; set; }
        public string Metadata { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public long CreateBy { get; set; }
        public long ModifyBy { get; set; }        
        public int Status { get; set; }

        public static long GetCurrentUserId()
        {
            HttpContextAccessor hca = new HttpContextAccessor();
            long? userId = hca.HttpContext?.User?.GetUserId();
            if (userId == null)
                return 0;
            return userId.Value;
        }
    }
}