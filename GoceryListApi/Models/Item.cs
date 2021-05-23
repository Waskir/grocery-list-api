using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoceryListApi.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public bool Done { get; set; }
    }
}
