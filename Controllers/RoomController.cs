using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Text_Adventure_2.Models;
using Text_Adventure_2.Services.RoomService;

namespace Text_Adventure_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService) {
            _roomService = roomService;
        }

        [HttpGet]
        public async Task<ActionResult<Rooms>> GetRoomByRoomNumber(int roomNumber)
        {
            return Ok(await _roomService.GetRoomByRoomNumber(roomNumber));
        }


    }
}
