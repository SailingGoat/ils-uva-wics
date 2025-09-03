using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace BffApi.Model.Response;

[DataContract]
public class ListingDetail
{
    [DataMember(Name = "timeStamp", IsRequired = true)]
    public string Timestamp { get; init; } = DateTime.UtcNow.ToString("o", CultureInfo.InvariantCulture);

    [DataMember(Name = "listingKey", IsRequired = true)]
    public required string ListingKey { get; init; } = "";

    [DataMember(Name = "id")]
    public required int Id { get; init; }
}
