using System.Collections.Generic;
using System.Runtime.Serialization;
using System.IO;

namespace InterfaceGW2Api.Models
{
    public class ItemCollection
    {
        public string[,] items { get; set; } 
    }

    public class SimpleItemViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }



}