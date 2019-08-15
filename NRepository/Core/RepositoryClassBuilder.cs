using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Core
{
    public abstract class RepositoryClassBuilder
    {
        public abstract TRepository CreateRepositoryInstance<TRepository>();

        public TypeBuilder CreateTypeBuilder()
        {
            var typeSignature = "DynamicRepository";
            var assemblyName = new AssemblyName(typeSignature);

            AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("DynamicNRepositoryModule");

            return moduleBuilder.DefineType(typeSignature,
                    TypeAttributes.Public |
                    TypeAttributes.Class |
                    TypeAttributes.AutoClass |
                    TypeAttributes.AnsiClass |
                    TypeAttributes.BeforeFieldInit |
                    TypeAttributes.AutoLayout,
                    null);
        }
    }
}
