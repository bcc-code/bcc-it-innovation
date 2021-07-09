using System.Collections.Generic;
using Telegram.Bot.Types.Payments;

namespace TelegramPay.Messages
{
    public class InputInvoiceMessageContent
    {
        public string Title { get; }
        public string Description { get; }
        public string Payload { get; }
        public string ProviderToken { get; }
        public List<LabeledPrice> Prices { get; }

        public InputInvoiceMessageContent(string title, string description, string payload, string providerToken, List<LabeledPrice> prices)
        {
            Title = title;
            Description = description;
            Payload = payload;
            ProviderToken = providerToken;
            Prices = prices;
        }

        public string? PhotoUrl { get; set; }
        public int PhotoWidth { get; set; }
        public int PhotoHeight { get; set; }
    }

}