namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        public MessageRecord(int roomID, string authorName, string text)
        {
            // Changes Sprint 1 -- I want to create rooms for categorizing conversations -- Mussie
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        public int RoomID
        {
            //Changes Sprint 2 - As a system administrator, I want to serve hundreds of users concurrently. - Sapphyre Rodriguez
            get;
            private set;
        }

        public string Text
        {
            // Changes Sprint 1 -- I want to create rooms for categorizing conversations -- Mussie
            get;
            private set;
        }

        public string AuthorName
        {
            get;
            private set;
        }
    }
}
