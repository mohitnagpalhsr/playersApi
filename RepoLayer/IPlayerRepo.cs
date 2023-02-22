using Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RepoLayer
{
    public interface IPlayerRepo<Player>
    {
        List<Player> GetAllPlayers();
        void AddPlayer (Player player);
        Player GetPlayerById (int id);
        Player GetPlayerByName (string name);
        void UpdatePlayer (int id, Player p);
        List<Player> GetPlayersBySportName(string name);
        //void RemovePlayer (int id);
    }
}