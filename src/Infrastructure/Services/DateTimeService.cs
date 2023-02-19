using Clean_Architecture.Application.Common.Interfaces;

namespace Clean_Architecture.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
