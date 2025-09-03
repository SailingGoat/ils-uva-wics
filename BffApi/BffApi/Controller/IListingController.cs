using System.Threading;
using BffApi.Model.Response;
using Microsoft.AspNetCore.Mvc;

namespace BffApi.Controller;

public interface IListingController
{
    ActionResult<ListingDetail> ListingByKey(string listingKey, CancellationToken token);
}
