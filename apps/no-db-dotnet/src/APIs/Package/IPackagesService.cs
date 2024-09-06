using NoDbDotnet.APIs.Dtos;

namespace NoDbDotnet.APIs;

public interface IPackagesService
{
    public Task<ProcessPackageOutput> ProcessPackage(ProcessPackageInput processPackageInputDto);
}
