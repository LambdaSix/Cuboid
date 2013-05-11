namespace Cuboid.LuaVM
{
    public interface ILuaVM
    {
        void Run();

        /// <summary>
        /// Register all methods in a given class marked with 
        /// the concrete implementation of ILuaFunctionAttribute
        /// </summary>
        /// <param name="target">Object to look at for methods</param>
        void RegisterLuaFunction(object target);
    }
}