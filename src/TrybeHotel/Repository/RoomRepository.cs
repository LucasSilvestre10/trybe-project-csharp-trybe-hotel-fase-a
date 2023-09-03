using TrybeHotel.Models;
using TrybeHotel.Dto;

namespace TrybeHotel.Repository
{
    public class RoomRepository : IRoomRepository
    {
        protected readonly ITrybeHotelContext _context;
        public RoomRepository(ITrybeHotelContext context)
        {
            _context = context;
        }

        // 6. Desenvolva o endpoint GET /room/:hotelId
        public IEnumerable<RoomDto> GetRooms(int HotelId)
        {
            var result = _context.Rooms.Where(room => room.HotelId == HotelId).Select(selRoom => new RoomDto
            {
                RoomId = selRoom.RoomId,
                Capacity = selRoom.Capacity,
                Name = selRoom.Name,
                Image = selRoom.Image,
                Hotel = _context.Hotels.Where(hotel => hotel.HotelId == HotelId).Select(selHotel => new HotelDto
                {
                    HotelId = selHotel.HotelId,
                    CityId = selHotel.CityId,
                    Name = selHotel.Name,
                    Address = selHotel.Address,
                    CityName = _context.Cities.Where(city => city.CityId == selHotel.CityId).Select(selCity => selCity.Name).FirstOrDefault()
                }).FirstOrDefault()
            }).ToList();
            return result;
        }

        // 7. Desenvolva o endpoint POST /room
        public RoomDto AddRoom(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
            var newRoom = new RoomDto
            {
                RoomId = room.RoomId,
                Capacity = room.Capacity,
                Name = room.Name,
                Image = room.Image,
                Hotel = _context.Hotels.Where(hotel => hotel.HotelId == room.HotelId).Select(selHotel => new HotelDto
                {
                    HotelId = selHotel.HotelId,
                    CityId = selHotel.CityId,
                    Name = selHotel.Name,
                    Address = selHotel.Address,
                    CityName = _context.Cities.Where(city => city.CityId == selHotel.CityId).Select(selCity => selCity.Name).FirstOrDefault()
                }).FirstOrDefault()
            };
            return newRoom;
        }

        // 8. Desenvolva o endpoint DELETE /room/:roomId
        public void DeleteRoom(int RoomId)
        {
            throw new NotImplementedException();
        }
    }
}