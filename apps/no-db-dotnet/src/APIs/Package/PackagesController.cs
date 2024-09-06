using Microsoft.AspNetCore.Mvc;
using NoDbDotnet.APIs;

namespace NoDbDotnet.APIs;

[ApiController()]
public class PackagesController : PackagesControllerBase
{
    public PackagesController(IPackagesService service)
        : base(service) { }
}
