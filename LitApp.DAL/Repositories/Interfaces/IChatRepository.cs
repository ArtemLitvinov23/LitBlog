﻿using LitApp.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LitApp.DAL.Repositories.Interfaces
{
    public interface IChatRepository
    {
        public Task<IEnumerable<ChatMessages>> GetFullChatHistory(int userId, int contactId);
        public Task SaveMessageAsync(ChatMessages message);
        Task RemoveMessage(int messageId);
        Task RemoveChatHistory(int userId, int contactId);
        Task RemoveAllMyMessages(int userId);
    }
}
