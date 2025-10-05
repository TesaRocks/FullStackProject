using FullStack.Models;

namespace FullStack.Services
{
    public interface IHomeService
    {
        public Task<Home> GetHomeImageAsync();
    }
}
