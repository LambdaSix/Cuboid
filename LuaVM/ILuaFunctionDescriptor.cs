using System.Collections.Generic;

namespace Cuboid.LuaVM
{
    public interface ILuaFunctionDescriptor
    {
        string FunctionName { get; }
        string FunctionDoc { get; }
        string FunctionHeader { get; }
        string FullFunctionDoc { get; }
        IEnumerable<string> FunctionParams { get; }
        IEnumerable<string> FunctionParamsDocs { get; }
    }
}