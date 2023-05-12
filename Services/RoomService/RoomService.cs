using Microsoft.EntityFrameworkCore;
using Text_Adventure_2.Data;
using Text_Adventure_2.Models;

namespace Text_Adventure_2.Services.RoomService
{
    public class RoomService : IRoomService
    {
        private readonly DataContext _context;

        public RoomService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Rooms>> GetRoomByRoomNumber(int roomNumber)
        {

            var currentRoom = await _context.Rooms
                .Where(r => r.RoomNumber == roomNumber).ToListAsync();

            return currentRoom;
       
        }
       

    }
}
