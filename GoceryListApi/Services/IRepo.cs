using GoceryListApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoceryListApi.Services
{
    public interface IRepo
    {
        List<Item> GetItems();
        Item GetItemById(int id);
        bool AddItem(Item newItem);
        bool DeleteItem(int id);
        bool UpdateItem(Item updatedItem);
    }
}
