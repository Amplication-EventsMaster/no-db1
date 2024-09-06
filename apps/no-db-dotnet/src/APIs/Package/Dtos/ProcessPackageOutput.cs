using System.ComponentModel.DataAnnotations;

namespace NoDbDotnet.APIs;

public class ProcessPackageOutput
{
    [Required()]
    public string Status { get; set; }

    public string? Message { get; set; }
}
