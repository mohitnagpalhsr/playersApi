using Models;
using RepoLayer;
using System.Collections.Generic;

namespace ServiceLayer
{
    public class PlayerService : IPlayerService<Player>
    {
        public static IPlayerRepo<Player> playerRepo;
        public PlayerService(IPlayerRepo<Player> _playerRepo)
        {
            playerRepo = _playerRepo;
        }

        public List<Player> GetAllPlayers()
        {
            return playerRepo.GetAllPlayers();
        }

        public void AddPlayer(Player player)
        {
            playerRepo.AddPlayer(player);
        }

        public void RemovePlayer(int id)
        {
            playerRepo.RemovePlayer(id);
        }

    }
}