using stockrain.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockrain.application.Services.Repository
{
    public interface IGetStocksRepository
    {
        public Task<List<InitialStock>> GetInitialStock();
    }
}
