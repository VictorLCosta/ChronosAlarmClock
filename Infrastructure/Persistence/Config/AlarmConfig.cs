using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Config
{
    public class AlarmConfig : IEntityTypeConfiguration<Alarm>
    {
        public void Configure(EntityTypeBuilder<Alarm> builder)
        {
            var valueComparer = new ValueComparer<List<DayOfWeek>>(
                (c1, c2) => c1!.SequenceEqual(c2!),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList());

            builder
                .Property(x => x.DaysOfWeek)
                .HasConversion(
                    v => string.Join(';', v!.Select(day => (int)day)),
                    v => v.Split(';', StringSplitOptions.RemoveEmptyEntries)
                            .Select(day => Enum.Parse<DayOfWeek>(day))
                            .ToList()
                );

            builder
                .Property(x => x.DaysOfWeek)
                .Metadata
                .SetValueComparer(valueComparer);

            builder
                .HasIndex(x => x.Active);
        }
    }
}
