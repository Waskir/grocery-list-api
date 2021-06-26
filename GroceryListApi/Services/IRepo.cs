using GoceryListApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoceryListApi.Services
{
    public interface IRepo
    {
        List<Item> GetListItems(int listId);
        Item GetItemById(int id);
        bool AddItem(Item newItem);
        bool DeleteItem(int id);
        bool UpdateItem(Item updatedItem);
        List<List> GetAllLists();
        List GetListById(int id);
        bool AddList(List newList);
        bool DeleteList(int id);
        bool UpdateList(List updatedList);
    }
}
