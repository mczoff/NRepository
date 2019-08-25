using NRepository.Core;
using NRepository.Tests.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Tests.CollectionTests.InterfacesTests.DeleteTests
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
        public void DeleteCompileTemplateTest()
        {
            var repository = _repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>())
                .Build<IGuidKeyTestDeleteRepository>();
        }

        [Test]
        public void DeleteModelTest()
        {
            var itemGuid = Guid.NewGuid();
            var itemValue = "9aa2bx3c";

            var repository = _repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>(new List<GuidKeyTestItem> { new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = itemGuid, Value = itemValue }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" } }))
                .Build<IGuidKeyTestDeleteRepository>();

            repository.Delete(itemGuid);

            Assert.That(repository.Select().Length, Is.EqualTo(2));
        }

        [Test]
        public void DeleteModelInFixedLenghtCollectionThrowsNotSupportedException()
        {
            var itemGuid = Guid.NewGuid();
            var itemValue = "9aa2bx3c";

            var repository = _repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>(new[] { new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = itemGuid, Value = itemValue }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" } }))
                .Build<IGuidKeyTestDeleteRepository>();

            Assert.That(() => repository.Delete(itemGuid), Throws.TypeOf<NotSupportedException>());
        }

        [Test]
        public void DeleteNullModelThrowsArgumentException()
        {
            var repository = _repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>(new List<GuidKeyTestItem> { new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" } }))
                .Build<IGuidKeyTestDeleteRepository>();

            GuidKeyTestItem model = null;

            Assert.That(() => repository.Delete(model), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void DeleteWithNotExistKeyThrowsArgumentException()
        {
            var repository = _repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>(new List<GuidKeyTestItem> { new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" } }))
                .Build<IGuidKeyTestDeleteRepository>();

            GuidKeyTestItem model = new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "not only fake item" };

            Assert.That(() => repository.Delete(model), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void DeleteByKeyWithNotExistKeyThrowsArgumentException()
        {
            var repository = _repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>(new List<GuidKeyTestItem> { new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" } }))
                .Build<IGuidKeyTestDeleteRepository>();

            GuidKeyTestItem model = new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "not only fake item" };

            Assert.That(() => repository.Delete(model.Id), Throws.TypeOf<ArgumentException>());
        }
    }
}
