using stockrain.application.Services.Repository;
using stockrain.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockrain.infrestructure.Services.Implementations
{
    public class GetStocksMockDataRepository : IGetStocksRepository
    {
        public async Task<List<InitialStock>> GetInitialStock()
        {
            List<InitialStock> Items = new();

            Items.Add(new InitialStock { Id = 1, Name = "Bitcoin", Price = 2502123 });
            Items.Add(new InitialStock { Id = 2, Name = "SP500", Price = 5201 });
            Items.Add(new InitialStock { Id = 3, Name = "Vanguard", Price = 2345 });
            Items.Add(new InitialStock { Id = 4, Name = "Facebook", Price = 7802 });

            return Items;
        }
    }
}
