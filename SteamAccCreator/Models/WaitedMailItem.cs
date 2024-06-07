using Newtonsoft.Json;
using SACModuleBase.Models;
using SteamAccCreator.Enums;
using System;
using System.Net;
using System.Text.RegularExpressions;
using Yove.Proxy;

using modEnums = SACModuleBase.Enums;

namespace SteamAccCreator.Models
{
    [Serializable]
    public class WaitedMailItem
    {


        public string Mail { get; set; }


        public WaitedMailItem() { }
        public WaitedMailItem(string plain)
        {
            Mail = plain;
        }

    }

}
