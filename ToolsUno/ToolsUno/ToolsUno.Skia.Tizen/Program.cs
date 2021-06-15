using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace ToolsUno.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new ToolsUno.App(), args);
            host.Run();
        }
    }
}
