using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoceryListApi.Models
{
    public class List
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class ListViewDto: List
    {
        public ICollection<Item> Items { get; set; }
    }
}
