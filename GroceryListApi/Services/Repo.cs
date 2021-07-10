using GoceryListApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoceryListApi.Services
{
    public class Repo : IRepo
    {
        private DataContext _db;

        public Repo(DataContext db)
        {
            _db = db;
        }

        public bool AddItem(Item newItem)
        {
            try
            {
                // Dodaje item do bazy danych
                _db.Items.Add(newItem);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddList(List newList)
        {
            try
            {
                // Dodaje listę do bazy danych
                _db.Lists.Add(newList);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteItem(int id)
        {
            try
            {
                // Usuwa item (ustawia kolumne IsDeleted = true)
                var itemToDelete = _db.Items.Where(item => item.Id == id).SingleOrDefault();
                itemToDelete.IsDeleted = true;
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteList(int id)
        {
            try
            {
                // Usuwa listę (ustawia kolumne IsDeleted = true)
                var listToDelete = _db.Lists.Where(list => list.Id == id).SingleOrDefault();
                listToDelete.IsDeleted = true;
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Item> GetListItems(int listId)
        {
            var response = new List<Item>();
            // Pobiera itemy z listy o podanym id
            response = _db.Items.Where(item => item.ListId == listId && item.IsDeleted == false).ToList();
            return response;
        }

        public Item GetItemById(int id)
        {
            var response = new Item();
            // Pobiera item po podanym id
            response = _db.Items.Where(item => item.Id == id && item.IsDeleted == false).SingleOrDefault();
            return response;
        }

        public List<ListViewDto> GetAllLists()
        {
            var response = new List<ListViewDto>();
            // Pobiera wszystkie listy
            response = _db.Lists
                .Where(list => list.IsDeleted == false)
                .Select(list => new ListViewDto
                    {
                        Id = list.Id,
                        Name = list.Name,
                        IsDeleted = list.IsDeleted,
                        Items = _db.Items.Where(item => item.ListId == list.Id && item.IsDeleted == false).ToList()
                    }
                ).ToList();
            return response;
        }

        public List GetListById(int id)
        {
            var response = new List();
            // Pobiera listę po podanym id
            response = _db.Lists.Where(list => list.Id == id && list.IsDeleted == false).SingleOrDefault();
            return response;
        }

        public bool UpdateItem(Item updatedItem)
        {
            try
            {
                // Usuwa item (ustawia kolumne IsDeleted = true)
                var itemToUpdate = _db.Items.Where(item => item.Id == updatedItem.Id).SingleOrDefault();
                itemToUpdate.Name = updatedItem.Name;
                itemToUpdate.Qty = updatedItem.Qty;
                itemToUpdate.Done = updatedItem.Done;
                itemToUpdate.IsDeleted = updatedItem.IsDeleted;
                _db.SaveChanges();
                return true; 
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateList(List updatedList)
        {
            try
            {
                // Usuwa listę (ustawia kolumne IsDeleted = true)
                var listToUpdate = _db.Lists.Where(list => list.Id == updatedList.Id).SingleOrDefault();
                listToUpdate.Name = updatedList.Name;
                listToUpdate.IsDeleted = updatedList.IsDeleted;
                _db.SaveChanges();
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}