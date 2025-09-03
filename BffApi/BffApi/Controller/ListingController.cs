using System.Threading;
using BffApi.Model.Response;
using BffApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BffApi.Controller;

[ApiController]
public class ListingController : ControllerBase, IListingController
{
    private readonly IListingRepository ListingRepository;

    public ListingController(IListingRepository listingRepository)
    {
        ListingRepository = listingRepository;
    }

    [HttpGet()]
    [Route("/listing/detail/{listingKey}")]
    public ActionResult<ListingDetail> ListingByKey(string listingKey, CancellationToken token)
    {
        if (!ModelState.IsValid)
        {
            return new BadRequestObjectResult(ModelState);
        }
        var dbListing = ListingRepository.ReadListing(listingKey);
        // ToDo: Mapping dbListing to ListingDetail object.
        return new ListingDetail()
        {
            ListingKey = listingKey,
            Id = dbListing.Id,
        };

    }
}
