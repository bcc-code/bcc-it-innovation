using System.Threading.Tasks;

namespace TelegramPay.Commands
{
    public class PreCheckoutAnswerCommand : IBotCommand
    {
        public string Command => "precheckoutanswer";

        public string Description => "Answers for PreCheckout query";

        public bool InternalCommand => true;
        public async Task Execute(IChatService chatService, long chatId, int userId, int messageId, string? commandText)
        {
            
        }
    }
}