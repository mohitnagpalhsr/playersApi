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
        void UpdatePlayer (int id, Player p);
        //void RemovePlayer (int id);
    }
}