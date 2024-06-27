using Semantica.Domain.DesignAttributes;

namespace Semantica.Lib.Tests.Design.Examples.Layered.Domain.Models;

[ValueObject<SimpleRootModel>(ModuleName = SimpleRoot.Module)]
public class LogModel
{
    public DateTime TimeStamp { get; set; }
    
    public string UserName { get; set; }
}
