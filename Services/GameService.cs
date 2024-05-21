using Microsoft.EntityFrameworkCore;
using mynewblazorapp.Data;
using mynewblazorapp.Entities;

namespace mynewblazorapp.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _context;

        public GameService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Game>> GetAllGames()
        {
            var games = await _context.Games.ToListAsync();
            return games;
        }
    }
}