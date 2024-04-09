using System.ComponentModel;

namespace Properties
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            House house = new House();
            Room room = new Room();
            Door houseDoor = new Door();
            Door roomDoor = new Door();

            house.Doors.Add(houseDoor);
            room.Door.Add(roomDoor);
            house.Rooms.Add(room);
        }
    }


    public class House
    {
        private List<Room> _rooms;
        private List<Door> _doors;

        public List<Room> Rooms => _rooms;
        public List<Door> Doors => _doors;

        public House()
        {
            _rooms = new List<Room>();
            _doors = new List<Door>();
        }
    }


    public class Room
    {
        private List<Door> _doors;
        public List<Door> Door => _doors;

        public Room()
        {
            _doors = new List<Door>();
        }
    }


    public class Door
    {
        private bool _isOpen;
        public bool IsOpen => _isOpen;

        public Door()
        {
            _isOpen = false;
        }

        public void Open()
        {
            if (_isOpen)
                Console.WriteLine("Door already opened. Ain't done anything.");
            else
                _isOpen = true;
        }

        public void Close()
        {
            if (!_isOpen)
                Console.WriteLine("Door already closed. Ain't done anything.");
            else
                _isOpen = false;
        }

    }
}
