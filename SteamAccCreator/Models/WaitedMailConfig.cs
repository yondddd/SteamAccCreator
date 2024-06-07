using System;
using System.Collections.Generic;

namespace SteamAccCreator.Models
{
    [Serializable]
    public class WaitedMailConfig
    {
        public bool Enabled { get; set; } = false;
        public IEnumerable<WaitedMailItem> List { get; set; } = new WaitedMailItem[0];
    }
}
