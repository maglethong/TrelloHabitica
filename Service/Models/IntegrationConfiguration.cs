using System.Collections.Generic;

namespace Service.Models
{
    public class IntegrationConfiguration
    {
        public class HabiticaDto
        {
            public string Id { get; set; }
            public string Token { get; set; }
        }
        
        public class TrelloDto
        {
            public string Token { get; set; }
            public string Id { get; set; }
            public string Board { get; set; }
            public HashSet<string> EntryLists { get; set; } 
            public HashSet<string> ExitLists { get; set; }
        }

        public HabiticaDto Habitica { get; set; }
        public TrelloDto Trello { get; set; }
    }
}