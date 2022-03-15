﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Streamish.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        public int VideoId { get; set; }
        public Video Video { get; set; }
    }
}