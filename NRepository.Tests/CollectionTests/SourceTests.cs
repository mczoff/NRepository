using NRepository.Core;
using NRepository.Tests.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Tests.CollectionTests
{
    public class SourceTests
    {
        private readonly IRepositoryBuilder _repositoryBuilder;

        public SourceTests()
        {
            _repositoryBuilder = new RepositoryBuilder();
        }


        [Test]
        public void CompileRepositoryWithoutSource()
        {
            var repository = _repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>())
                .Build<IGuidKeyTestSelectRepository>();

            Assert.That(() => repository.Select().Length, Is.EqualTo(0));
        }

        [Test]
        public void CompileInitializeRepositoryWithSource()
        {
            GuidKeyTestItem[] source = new[] { new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "First value" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "Second value" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "Third value" } };

            var repository =_repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>(source))
                .Build<IGuidKeyTestSelectRepository>();

            Assert.That(() => repository.Select().Length, Is.EqualTo(3));
        }

        [Test]
        public void CompileRepositoryWithNullSource()
        {
            GuidKeyTestItem[] source = null;

            Assert.That(() => _repositoryBuilder.SetSource(new CollectionRepositorySource<GuidKeyTestItem>(source)).Build<IGuidKeyTestSelectRepository>(), Throws.ArgumentNullException);
        }
    }
}
