using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;

namespace TelegramPay.Commands
{
    public class StartCommand : IBotCommand
    {
        public string Command => "donate";

        public string Description => "Donate";

        public bool InternalCommand => false;

        public async Task Execute(IChatService chatService, long chatId, int userId, int messageId, string? commandText)
        {
            await chatService.SendMessage(chatId, $"Please choose an amount to donate.", ParseMode.MarkdownV2, new Dictionary<string, string>
            {
                {"10 PLN", "/invoice 10"},
                {"20 PLN", "/invoice 20"},
                {"50 PLN", "/invoice 50"},
                {"100 PLN", "/invoice 100"},
                {"200 PLN", "/invoice 200"},
            });
        }
    }
}