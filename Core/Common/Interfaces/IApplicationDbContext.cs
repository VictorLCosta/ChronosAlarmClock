using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Alarm> Alarms { get; }
        public DbSet<Ringtone> Ringtones { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
