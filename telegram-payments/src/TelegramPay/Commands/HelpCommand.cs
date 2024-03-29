﻿using System;
using System.Threading.Tasks;

namespace TelegramPay.Commands
{
    public class HelpCommand
    {
        private readonly IServiceProvider _serviceProvider;

        public string Command => "help";

        public string Description => "Get information about the functionality available for this bot";

        public bool InternalCommand => true;

        public HelpCommand(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task Execute(IChatService chatService, long chatId, int userId, int messageId, string? commandText)
        {
            await chatService.SendMessage(chatId, "TODO: Create a todo command");
        }
    }
}
