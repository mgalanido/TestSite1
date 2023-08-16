using System;
using TestSite1.Application.Interfaces.Services;

namespace TestSite1.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}