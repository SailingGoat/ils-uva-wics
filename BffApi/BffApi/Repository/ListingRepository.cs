using BffApi.Repository.Model;

namespace BffApi.Repository;

public class ListingRepository : IListingRepository
{
    public Listing ReadListing(string listingKey)
    {
        return new Listing()
        { 
            Id = 123,
        };
    }
}
