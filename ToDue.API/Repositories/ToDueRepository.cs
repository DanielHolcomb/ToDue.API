using Microsoft.Azure.Cosmos;
using ToDue.API.Interfaces;
using ToDue.API.Models;

namespace ToDue.API.Repositories;

public class ToDueRepository : IToDueRepository
{
    private readonly CosmosClient _cosmosClient;

    public ToDueRepository(CosmosClient cosmosClient, IConfiguration config)
    {
        _cosmosClient = new CosmosClient(connectionString: config.GetSection("Cosmos").Value);
    }

    public async Task<ToDueItem> CreateToDueItemAsync(ToDueItem toDueItem)
    {
        throw new NotImplementedException();
    }
}
