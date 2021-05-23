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
                // Dodaje Item do bazy danych
                _db.Items.Add(newItem);
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
                // Usuwa Item (ustawia kolumne IsDeleted = true)
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

        public Item GetItemById(int id)
        {
            var response = new Item();
            // Pobiera item po podanym id
            response = _db.Items.Where(item => item.Id == id && item.IsDeleted == false).SingleOrDefault();
            return response;
        }

        public List<Item> GetItems()
        {
            // Pobiera wszystkie itemy
            var response = new List<Item>();
            response = _db.Items.Where(item => item.IsDeleted == false).ToList();
            return response;
        }

        public bool UpdateItem(Item updatedItem)
        {
            try
            {
                // Usuwa Item (ustawia kolumne IsDeleted = true)
                var itemToUpdate = _db.Items.Where(item => item.Id == updatedItem.Id).SingleOrDefault();
                itemToUpdate.Name = updatedItem.Name;
                itemToUpdate.Qty = updatedItem.Qty;
                itemToUpdate.Done = updatedItem.Done;
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
