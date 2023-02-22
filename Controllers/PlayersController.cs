using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using ServiceLayer;

namespace SportsEventAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        public static IPlayerService<Player> playerService;

        public PlayersController(IPlayerService<Player> _playerService)
        {
            playerService = _playerService;
        }

        // GET: api/Players
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetAllPlayers()
        {
            return Ok(playerService.GetAllPlayers());
        }

        // POST: api/Players
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Player>> AddPlayer(Player player)
        {
            playerService.AddPlayer(player);
            return Ok();
        }

        [HttpGet]
        [Route("PlayerById")]
        public async Task<ActionResult<Player>> GetPlayerById(int id)
        {
            var e = playerService.GetPlayerById(id);
            if(e is null)
            return NotFound();
            else
            return Ok(e);
        }

        [HttpPut]
        public async Task<ActionResult<Player>> UpdatePlayer(int id,Player p) 
        {
            playerService.UpdatePlayer(id,p);
            return Ok(); 
        }
        
        /*// DELETE: api/Players/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemovePlayer(int id)
        {
            playerService.RemovePlayer(id);
            return Ok();
        }*/
    }
}