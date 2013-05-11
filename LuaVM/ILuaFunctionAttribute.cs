using System.Collections.Generic;

namespace Cuboid.LuaVM
{
    public interface ILuaFunctionAttribute
    {
        string FunctionName { get; set; }
        string FunctionDoc { get; set; }
        IEnumerable<string> FunctionParams { get; set; }
    }
}