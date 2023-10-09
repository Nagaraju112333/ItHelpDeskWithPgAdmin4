namespace Ondc.Seller.Integration.Interfaces;

public interface IMessageService
{
    Task SendMessageAsync(string folderName);
}
