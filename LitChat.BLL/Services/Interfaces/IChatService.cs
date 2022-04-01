﻿using LitChat.BLL.ModelsDto;
using LitChat.BLL.ModelsDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LitChat.BLL.Services.Interfaces
{
    public interface IChatService
    {
        public Task<List<ChatMessagesDto>> GetLastFourMessagesAsync(int userId, int contactId);
        public Task<List<ChatMessagesDto>> GetFullHistoryMessagesAsync(int userId, int contactId);
        public Task<StatusEnum> SaveMessageAsync(int userId, ChatMessagesDto chatMessage);
        Task<StatusEnum> RemoveMessage(int messageId);
        Task<StatusEnum> RemoveChatHistory(int userId, int contactId);
    }
}
