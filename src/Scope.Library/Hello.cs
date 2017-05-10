
namespace Scope.Library
{
    public static class Hello
    {
        public static string World(string name = null)
        {
            return string.IsNullOrEmpty(name) ? "Hello world!" : $"Hello {name}!";
        }
    }
}
