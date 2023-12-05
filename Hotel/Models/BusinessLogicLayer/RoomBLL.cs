using Multi_Login.Models.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Login.Models.BusinessLogicLayer
{
    public class RoomBLL
    {
        public ObservableCollection<Room> RoomsList { get; set; }

        RoomDAL roomDAL = new RoomDAL();

        public RoomBLL()
        {
            RoomsList= roomDAL.GetAllRooms();
        }

        public ObservableCollection<Room> GetAllRooms()
        {
            return roomDAL.GetAllRooms();
        }

        public void AddRooms(Room room)
        {
            RoomsList.Add(room);
        }
    }
}
