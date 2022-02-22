﻿using LitChat.DAL.Models;
using System;

namespace LitChat.BLL.ModelsDto
{
    public class FriendViewModel
    {
        public int RequestById { get; set; }

        public int FriendId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? RequestTime { get; set; }

        public RequestFlags RequestFlags { get; set; }

        public bool Approved { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public DateTime? DateOfRejection { get; set; }

        public DateTime? NextRequest { get; set; }
    }
}
