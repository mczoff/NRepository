using NRepository.Core;
using NRepository.Tests.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Tests.CollectionTests.InterfacesTests.CreateTests
{
    [TestFixture]
    public class GuidRepositoryTests
    {
        private readonly IRepositoryBuilder _repositoryBuilder;

        public GuidRepositoryTests()
        {
            _repositoryBuilder = new RepositoryBuilder();
        }

        [Test]
        public void CreateCompileTemplateTest()
        {
            var repository = _repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>())
                .Build<IGuidKeyTestCreateRepository>();
        }

        [Test]
        public void CreateModelInFixedLenghtCollectionThrowsNotSupportedException()
        {
            var itemGuid = Guid.NewGuid();
            var itemValue = "9aa2bx3c";

            var repository = _repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>(new[] { new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" } }))
                .Build<IGuidKeyTestCreateRepository>();


            Assert.That(() => repository.Create(new GuidKeyTestItem { Id = itemGuid, Value = itemValue }), Throws.TypeOf<NotSupportedException>());
        }

        [Test]
        public void CreateModelInCollection()
        {
            var itemGuid = Guid.NewGuid();
            var itemValue = "9aa2bx3c";

            var repository = _repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>(new List<GuidKeyTestItem> { new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" } }))
                .Build<IGuidKeyTestCreateRepository>();

            var item = repository.Create(new GuidKeyTestItem { Id = itemGuid, Value = itemValue });

            Assert.That(repository.Select().Length, Is.EqualTo(4));
        }

        [Test]
        public void CreateModelWillReturnModelIdTest()
        {
            var itemGuid = Guid.NewGuid();
            var itemValue = "9aa2bx3c";

            var repository = _repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>(new List<GuidKeyTestItem> { new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" } }))
                .Build<IGuidKeyTestCreateRepository>();

            var item = repository.Create(new GuidKeyTestItem { Id = itemGuid, Value = itemValue });

            Assert.That(itemGuid, Is.EqualTo(item));
        }
    }
}
