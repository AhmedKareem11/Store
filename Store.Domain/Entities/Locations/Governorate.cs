using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities.Addresses;
public class Governorate
{
    public int Id { get; set; }
    public required string NameAr { get; set; }
    public required string NameEn { get; set; }
    public ICollection<City> Cities { get; set; } = null!;
}