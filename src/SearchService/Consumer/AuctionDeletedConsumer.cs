using Contracts;
using MassTransit;
using MongoDB.Entities;
using Polly;
using SearchService.Models;

namespace SearchService;

public class AuctionDeletedConsumer : IConsumer<AuctionDeleted>
{
    public async Task Consume(ConsumeContext<AuctionDeleted> context)
    {
        Console.WriteLine("--> Consuming UactionDeleted: " + context.Message.Id);

        var Result = await DB.DeleteAsync<Item>(context.Message.Id);

        if (!Result.IsAcknowledged) throw new MessageException(typeof(AuctionDeleted), "Problem deleting auction");
    }
}
