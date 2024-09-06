using Microsoft.AspNetCore.Mvc;
using NoDbDotnet.APIs;
using NoDbDotnet.APIs.Dtos;

namespace NoDbDotnet.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class PackagesControllerBase : ControllerBase
{
    protected readonly IPackagesService _service;

    public PackagesControllerBase(IPackagesService service)
    {
        _service = service;
    }

    [HttpPost("process-package")]
    public async Task<ProcessPackageOutput> ProcessPackage(
        [FromBody()] ProcessPackageInput processPackageInputDto
    )
    {
        return await _service.ProcessPackage(processPackageInputDto);
    }
}
