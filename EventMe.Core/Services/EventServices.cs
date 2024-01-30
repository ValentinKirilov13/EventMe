using EventMe.Core.Contracts;
using EventMe.Core.ViewModels;
using EventMe.Data.Data;

namespace EventMe.Core.Services
{
    public class EventServices : IEventServices
    {
        private readonly EventMeDbContext context;

        public EventServices(EventMeDbContext _context)
        {
            context = _context;
        }

        public Task AddAsync(EventViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EventViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
