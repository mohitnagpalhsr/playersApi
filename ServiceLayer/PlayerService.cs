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

        public Player GetPlayerById (int id){
            var e=playerRepo.GetPlayerById(id);
             return (e); 
        }

        public void UpdatePlayer(int id, Player p)
        {
            playerRepo.UpdatePlayer(id,p);
        }

        /*public void RemovePlayer(int id)
        {
            playerRepo.RemovePlayer(id);
        }*/

    }
}