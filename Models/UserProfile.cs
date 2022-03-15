﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Streamish.Models
{
    public class UserProfile
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string FirebaseUserId { get; set; }

        public string ImageUrl { get; set; }

        public DateTime DateCreated { get; set; }

        public List<Video> Videos { get; set; }


    }
}