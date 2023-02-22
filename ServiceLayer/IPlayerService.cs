using System.Collections.Generic;
using Models;

namespace ServiceLayer
{
    public interface IPlayerService<Player>
    {
        List<Player> GetAllPlayers();
        void AddPlayer(Player player);
        Player GetPlayerById (int id);
        void RemovePlayer(int id);
    }
}