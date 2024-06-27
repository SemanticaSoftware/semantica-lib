using Semantica.Domain.DesignAttributes;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;

[ValueObject<SimpleRootUnlayeredModel>(ModuleName = SimpleRootUnlayered.Module)]
public class LogModel
{
    public DateTime TimeStamp { get; set; }
    
    public string UserName { get; set; }
}
