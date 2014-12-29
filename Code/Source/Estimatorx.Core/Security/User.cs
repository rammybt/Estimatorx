﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNet.Identity;

namespace Estimatorx.Core.Security
{
    public class User
        : IUser<string>
    {
        public User()
        {
            Roles = new List<string>();
            Claims = new List<Claim>();
            Logins = new List<Login>();
        }

        public string Id { get; set; }

        public string UserName { get; set; }


        public string Email { get; set; }

        [DefaultValue(false)]
        public bool EmailConfirmed { get; set; }


        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }


        public string PhoneNumber { get; set; }

        [DefaultValue(false)]
        public bool PhoneNumberConfirmed { get; set; }


        [DefaultValue(false)]
        public bool TwoFactorEnabled { get; set; }


        public DateTime? LockoutEndDateUtc { get; set; }

        [DefaultValue(false)]
        public bool LockoutEnabled { get; set; }

        [DefaultValue(0)]
        public int AccessFailedCount { get; set; }


        public IList<string> Roles { get; set; }

        public ICollection<Claim> Claims { get; set; }

        public ICollection<Login> Logins { get; set; }
    }
}