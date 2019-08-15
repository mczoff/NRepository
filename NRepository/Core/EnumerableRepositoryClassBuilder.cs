using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Core
{
    public class EnumerableRepositoryClassBuilder
        : RepositoryClassBuilder
    {
        public override TRepository CreateRepositoryInstance<TRepository>()
        {
            var repositoryInterfaces = typeof(TRepository).GetInterfaces();

            var typeBuilder = CreateTypeBuilder();

            typeBuilder.AddInterfaceImplementation(typeof(TRepository));

            foreach (var repositoryInterface in repositoryInterfaces)
            {
                foreach (var repositoryInterfaceMethod in repositoryInterface.GetMethods())
                {
                    MethodBuilder myMethodBuilder = typeBuilder.DefineMethod(
                        repositoryInterfaceMethod.Name,
                        MethodAttributes.Public | MethodAttributes.Virtual,
                        repositoryInterfaceMethod.ReturnType,
                        repositoryInterfaceMethod.GetParameters().Select(t => t.ParameterType).ToArray());

                    ILGenerator myMethodIL = myMethodBuilder.GetILGenerator();

                    myMethodIL.Emit(OpCodes.Ldnull);
                    myMethodIL.Emit(OpCodes.Ret);

                    typeBuilder.DefineMethodOverride(myMethodBuilder, repositoryInterfaceMethod);
                }
            }

            var repository = typeBuilder.CreateType();
            return (TRepository)Activator.CreateInstance(repository); ;
        }
    }
}
