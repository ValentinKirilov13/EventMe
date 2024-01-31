using EventMe.Core.Contracts;
using EventMe.Core.ViewModels;
using EventMe.Data.Data;
using EventMe.Data.Data.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace EventMe.Core.Services
{
    public class EventServices : IEventServices
    {
        private readonly EventMeDbContext context;

        public EventServices(EventMeDbContext _context)
        {
            context = _context;
        }

        public async Task AddAsync(EventViewModel model)
        {
            Event newEvent = new Event()
            {
                Id = model.Id,
                Name = model.Name,
                Place = model.Place,
                Start = model.Start,
                End = model.End,
            };

            await context.Events.AddAsync(newEvent);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            Event model = await context.Events.FindAsync(id);

            model.IsDeleted = true;

            await context.SaveChangesAsync();
        }

        public Task EditAsync(EventViewModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EventViewModel>> GetAllAsync()
        {
            return await context.Events
                .Where(x => x.IsDeleted == false)
                .Select(x => new EventViewModel() 
                {
                    Id = x.Id,
                    Name = x.Name,
                    Place = x.Place,
                    Start = x.Start,
                    End = x.End,
                })
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<EventViewModel> GetByIdAsync(Guid id)
        {
            return await context.Events
                .Where(x => x.Id == id)
                .AsNoTracking()
                .Select(x => new EventViewModel() 
                {
                    Id = x.Id,
                    Name = x.Name,
                    Place = x.Place,
                    Start = x.Start,
                    End = x.End,
                })
                .FirstAsync();
        }
    }
}
