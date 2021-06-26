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

    public class AddListDto
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
