using System;
using System.Collections.Generic;
using System.Text;
using MultiUserApp.Models;
using System.Threading.Tasks;

namespace MultiUserApp.ViewModels
{

    public class HorseProfileManager
    {
        ISimpleDBStorage storage;

        public HorseProfileManager(ISimpleDBStorage simpleDBStorage)
        {
            storage = simpleDBStorage;
        }

        public Task<List<Horse>> GetTasksAsync()
        {
            return storage.RefreshDataAsync();
        }

        public Task SaveTaskAsync(Horse item)
        {
            return storage.SaveTodoItemAsync(item);
        }

        public Task DeleteTaskAsync(Horse item)
        {
            return storage.DeleteTodoItemAsync(item);
        }

    }
}
