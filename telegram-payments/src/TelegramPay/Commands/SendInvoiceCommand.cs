using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot.Types.Payments;
using TelegramPay.Messages;

namespace TelegramPay.Commands
{
    public class SendInvoiceCommand : IBotCommand
    {
        public string Command => "invoice";

        public string Description => "This is a simple command that can be used to test if the bot is online";

        public bool InternalCommand => true;

        public async Task Execute(IChatService chatService, long chatId, int userId, int messageId, string? commandText)
        {
            
            if (commandText != null)
            {
                var prices = new List<LabeledPrice>
                {
                    new($"{commandText} PLN", int.Parse(commandText)*100),
                };

                var invoice = new InputInvoiceMessageContent("Donation", "Click a button below to proceed to the payment",
                    "payload",
                    chatService.GetProviderToken(), prices)
                {
                    PhotoUrl = "https://storage.googleapis.com/dev-myshare-storage/logo.jpg",
                    PhotoWidth = 261,
                    PhotoHeight = 51
                };

                await chatService.SendInvoice((int)chatId, invoice);
            }
        }
    }
}