using ProjectApi.Entities.Models;

namespace Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Users> Users { get; }
        IRepository<Address> Addresses { get; }
        IRepository<Booking> Bookings { get; }
        IRepository<BookingDetails> BookingDetails { get; }
        IRepository<BookingStatus> BookingStatuses { get; }
        IRepository<PaymentMethod> PaymentMethods { get; }
        IRepository<Payments> Payments { get; }
        IRepository<Reviews> Reviews { get; }
        IRepository<ServiceGroups> ServiceGroups { get; }
        IRepository<ServiceProviders> ServiceProviders { get; }
        IRepository<ServiceProviderType> ServiceProviderTypes { get; }
        IRepository<SubService> SubServices { get; }

        int Save();
    }
}
