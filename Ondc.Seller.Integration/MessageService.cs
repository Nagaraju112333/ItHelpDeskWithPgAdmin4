using Microsoft.Extensions.Configuration;
using Ondc.Seller.Integration.Interfaces;

namespace Ondc.Seller.Integration;
public class MessageService : IMessageService
{
    private readonly IConfiguration _configuration;

    public MessageService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public Task SendMessageAsync(string folderName)
    {
        throw new NotImplementedException();
    }
}

