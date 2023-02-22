using System.Collections.Generic;
using Models;

namespace ServiceLayer
{
    public interface IPlayerService<Player>
    {
        List<Player> GetAllPlayers();
        void AddPlayer(Player player);
        Player GetPlayerById (int id);
        Player GetPlayerByName (string name);
        void UpdatePlayer(int id, Player p);
        //void RemovePlayer(int id);
        List<Player> GetPlayersBySportName(string name);
    }
}