using System.Reflection;

namespace WalletApp.Application.Configuraciones.Assemblies
{
    public static class AplicationAssembly
    {
        public static Assembly GetAssembly()
            => Assembly.GetExecutingAssembly();
    }
}
