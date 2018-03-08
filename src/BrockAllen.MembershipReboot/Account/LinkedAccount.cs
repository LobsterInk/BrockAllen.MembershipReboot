/*
 * Copyright (c) Brock Allen.  All rights reserved.
 * see license.txt
 */

using System;
using System.ComponentModel.DataAnnotations;

namespace BrockAllen.MembershipReboot
{
    public class LinkedAccount
    {
        [StringLength(200)]
        [Required]
        public virtual string ProviderName { get; set; }
        [StringLength(100)]
        [Required]
        public virtual string ProviderAccountID { get; set; }

        public virtual DateTime? LastLogin { get; set; }

        public DateTime? DisabledAt { get; set; }

        public DateTime? DeactivatedAt { get; set; }
    }
}
