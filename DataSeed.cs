using TaskApi.Models;

namespace TaskApi
{
    public class DataSeed
    {
        private readonly ApiContext _ctx;

        public DataSeed(ApiContext ctx)
        {
            _ctx = ctx;
        }

        public void SeedData()
        {
            
        }
    }
}