using mynewblazorapp.Entities;

namespace mynewblazorapp.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
    }
}