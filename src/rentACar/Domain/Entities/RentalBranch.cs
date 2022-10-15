using Core.Persistence.Repositories;
using Domain.Enums;

namespace Domain.Entities;

public class RentalBranch : Entity
{
    public City City { get; set; }
   

    public virtual ICollection<Rental> Rentals { get; set; }

    public RentalBranch()
    {
        Rentals = new HashSet<Rental>();
    }

    public RentalBranch(int id, City city) : this()
    {
        Id = id;
        City = city;
    }
}