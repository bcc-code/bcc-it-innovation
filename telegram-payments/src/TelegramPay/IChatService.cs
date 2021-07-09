using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using TelegramPay.Messages;

namespace TelegramPay
{
    public interface IChatService
    {
        event EventHandler<ChatMessageEventArgs> ChatMessage;
        event EventHandler<CallbackEventArgs>? Callback;

        Task<string> BotUserName();
        Task<bool> SendMessage(long chatId, string? message, ParseMode parseMode = ParseMode.MarkdownV2, Dictionary<string, string>? buttons = null);
        Task<bool> UpdateMessage(long chatId, int messageId, string newText, Dictionary<string, string>? buttons = null);
        Task<string> GetChatMemberName(long chatId, int userId);

        Task<bool> SendInvoice(int chatId, InputInvoiceMessageContent content);
        string GetProviderToken();
    }
}
