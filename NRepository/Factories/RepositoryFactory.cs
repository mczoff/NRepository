using NRepository.Abstractions.Core;
using NRepository.Attributes;
using NRepository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Factories
{
    public static class RepositoryFactory
    {
        private static readonly string[] _assemblies = new[] { "NRepository", "NRepository.EntityFramework" };

        public static TRepository Create<TRepository>(object repositorySource)
        {
            var policyTypes = _assemblies.SelectMany(t => GetPolicyFromAssembly(Assembly.Load(t)));

            var policyType = policyTypes.FirstOrDefault(t => t.GetCustomAttribute<RepositoryPolicyAttribute>().RepositorySourceType.GUID == repositorySource.GetType().GUID);

            var policyMethod = policyType.GetMethod("GetClassBuilder");

            var policy = Activator.CreateInstance(policyType);

            var repositoryClassBuilder = policyMethod.Invoke(policy, new object[] { }) as IRepositoryClassBuilder;

            return repositoryClassBuilder.CreateRepositoryInstance<TRepository>(repositorySource);
        }

        private static Type[] GetPolicyFromAssembly(Assembly assembly)
            => assembly.GetTypes().Where(k => k.GetCustomAttribute<RepositoryPolicyAttribute>() != null).ToArray();
    }
}
