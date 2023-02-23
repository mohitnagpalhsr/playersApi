using Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace RepoLayer
{
    public class PlayerRepo : IPlayerRepo<Player> 
    {
        private readonly SportsEventManagementContext _context;
        public PlayerRepo(SportsEventManagementContext context)
        {
            _context = context;
        }
        public List<Player> GetAllPlayers()
        {
            return _context.Players.ToList();
        }
        public void AddPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
        }

         public Player GetPlayerById(int id)
        {
            
            Player e = _context.Players.Find(id);
            
           return (e);
        }

        public Player GetPlayerByName(string name)
        {
            
            Player e = _context.Players.SingleOrDefault(x=>x.PlayerName==name);
            
           return (e);
        }

        /*public void RemovePlayer(int id)
        {
            Player player = _context.Players.Find(id);
            _context.Players.Remove(player);
            _context.SaveChanges();
        }*/
        public void UpdatePlayer(int id, Player p)
        {
            //_context.Players.UpdatePlayer(p); //here no
            _context.Entry(p).State=EntityState.Modified;
            _context.SaveChanges();
        }

        public List<Player> GetPlayersBySportName(string name)
        {
            var e= _context.Players.Where(item => (item.SportsName == name) && (item.Status=="active"))
                       .ToList();
            return (e);
        }
    }
}