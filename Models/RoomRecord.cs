namespace CIS3285_Unit3Sample_2024.Models
{
    public class RoomRecord
    {
        public RoomRecord(string name, int roomId)
        {
            // Changes Sprint 1 -- I want to create rooms for categorizing conversations -- Mussie
            Name = name;
            RoomId1 = roomId;
        }

        int RoomId;
        public int RoomId1 { get => RoomId; set => RoomId = value; }

        public string Name
        {
            //Changes Sprint 2 - As a system administrator, I want to serve hundreds of users concurrently. - Sapphyre Rodriguez
            get;
            private set;
        }
    }
}
