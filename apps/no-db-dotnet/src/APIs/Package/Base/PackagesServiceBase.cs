using NoDbDotnet.APIs;
using NoDbDotnet.APIs.Dtos;
using NoDbDotnet.Infrastructure;
using NoDbDotnet.Infrastructure.Models;

namespace NoDbDotnet.APIs;

public abstract class PackagesServiceBase : IPackagesService
{
    protected readonly NoDbDotnetDbContext _context;

    public PackagesServiceBase(NoDbDotnetDbContext context)
    {
        _context = context;
    }

    public async Task<ProcessPackageOutput> ProcessPackage(
        ProcessPackageInput processPackageInputDto
    )
    {
        throw new NotImplementedException();
    }
}
