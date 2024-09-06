using Microsoft.AspNetCore.Mvc;
using NoDbDotnet.Infrastructure;

namespace NoDbDotnet.APIs;

public class PackagesService : PackagesServiceBase
{
    public PackagesService(NoDbDotnetDbContext context)
        : base(context) { }
}
