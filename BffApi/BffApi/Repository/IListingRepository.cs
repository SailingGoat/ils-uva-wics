using BffApi.Repository.Model;

namespace BffApi.Repository;

public interface IListingRepository
{
    Listing ReadListing(string listingKey);
}
