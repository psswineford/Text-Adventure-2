using Text_Adventure_2.Models;

namespace Text_Adventure_2.Services.RoomService
{
    public interface IRoomService
    {
        Task<Rooms> GetRoomByRoomNumber(int roomNumber);
    }
}
