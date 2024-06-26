﻿using System.ComponentModel.DataAnnotations;
using System.Net;
using System;

namespace Acklann.Plaid.Demo.DataLayer
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string RequestId { get; set; }

        public string ItemId { get; set; }

        public string InstitutionId { get; set; }

        public string AccessToken { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}