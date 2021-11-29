﻿using System;

namespace LitBlog.API.Models
{
    public class ChatMessageModel
    {
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        public ApplicationUserViewModel FromUser { get; set; }
        public ApplicationUserViewModel ToUser { get; set; }
    }
}
