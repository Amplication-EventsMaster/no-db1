using System.ComponentModel.DataAnnotations;

namespace NoDbDotnet.APIs;

public class ProcessPackageInput
{
    [Required()]
    public string PackageId { get; set; }

    [Required()]
    public string PackageDetails { get; set; }
}
