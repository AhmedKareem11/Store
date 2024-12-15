using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities.Addresses;

public class City
{
    public int Id { get; set; }
    public required string NameAr { get; set; } = string.Empty;
    public required string NameEn { get; set; } = string.Empty;
    public required int GovernorateId { get; set; }
    public Governorate? Governorate { get; set; }
}
