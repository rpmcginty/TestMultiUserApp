using System.Threading.Tasks;
using System.Collections.Generic;
using MultiUserApp.Models;


namespace MultiUserApp.ViewModels
{
    public interface ISimpleDBStorage
    {
        Task<List<Horse>> RefreshDataAsync();

        Task SaveTodoItemAsync(Horse item);

        Task DeleteTodoItemAsync(Horse id);
    }
}