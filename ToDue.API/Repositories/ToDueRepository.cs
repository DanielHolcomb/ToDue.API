using Microsoft.Azure.Cosmos;
using System.ComponentModel;
using System;
using ToDue.API.Interfaces;
using ToDue.API.Models;
using Microsoft.Azure.Cosmos.Linq;

namespace ToDue.API.Repositories;

public class ToDueRepository : IToDueRepository
{
    private readonly CosmosClient _cosmosClient;
    private readonly Microsoft.Azure.Cosmos.Container _container;

    public ToDueRepository(IConfiguration config)
    {
        _cosmosClient = new CosmosClient(connectionString: config.GetSection("Cosmos").Value);
        _container = _cosmosClient.GetContainer("DHDB", "ToDue");
    }

    public async Task<ToDueItem> CreateToDueItemAsync(ToDueItem toDueItem)
    {
        var newToDueItem = await _container.UpsertItemAsync(toDueItem);

        return newToDueItem;
    }

    public async Task<List<ToDueItem>> GetAllToDueItemsAsync()
    {
        var allToDueItems = new List<ToDueItem>();
        var q = _container.GetItemLinqQueryable<ToDueItem>();
        var iterator = q.ToFeedIterator();
        allToDueItems.AddRange(await iterator.ReadNextAsync());
        return allToDueItems;
    }
}
