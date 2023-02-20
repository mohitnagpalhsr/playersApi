using Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RepoLayer
{
    public interface IPlayerRepo<Player>
    {
        List<Player> GetAllPlayers();
        void AddPlayer (Player player);
        void RemovePlayer (int id);
    }
}