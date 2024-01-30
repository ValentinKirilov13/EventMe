using EventMe.Core.ViewModels;

namespace EventMe.Core.Contracts
{
    public interface IEventServices
    {
        Task<IEnumerable<EventViewModel>> GetAllAsync();

        Task AddAsync(EventViewModel model);

        Task EditAsync(EventViewModel model);

        Task DeleteAsync(Guid id);
    }
}
