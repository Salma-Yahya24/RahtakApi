using Interfaces;
using ProjectApi.DAL.Data;
using ProjectApi.Entities.Models;

namespace Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;

        Users = new Repository<Users>(_context);
        Addresses = new Repository<Address>(_context);
        Bookings = new Repository<Booking>(_context);
        BookingDetails = new Repository<BookingDetails>(_context);
        BookingStatuses = new Repository<BookingStatus>(_context);
        PaymentMethods = new Repository<PaymentMethod>(_context);
        Payments = new Repository<Payments>(_context);
        Reviews = new Repository<Reviews>(_context);
        ServiceGroups = new Repository<ServiceGroups>(_context);
        ServiceProviders = new Repository<ServiceProviders>(_context);
        ServiceProviderTypes = new Repository<ServiceProviderType>(_context);
        SubServices = new Repository<SubService>(_context);
    }

    public IRepository<Users> Users { get; }
    public IRepository<Address> Addresses { get; }
    public IRepository<Booking> Bookings { get; }
    public IRepository<BookingDetails> BookingDetails { get; }
    public IRepository<BookingStatus> BookingStatuses { get; }
    public IRepository<PaymentMethod> PaymentMethods { get; }
    public IRepository<Payments> Payments { get; }
    public IRepository<Reviews> Reviews { get; }
    public IRepository<ServiceGroups> ServiceGroups { get; }
    public IRepository<ServiceProviders> ServiceProviders { get; }
    public IRepository<ServiceProviderType> ServiceProviderTypes { get; }
    public IRepository<SubService> SubServices { get; }

    public int Save()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
