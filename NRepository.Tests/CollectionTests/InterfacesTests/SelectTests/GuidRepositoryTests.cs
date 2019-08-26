using NRepository.Core;
using NRepository.Tests.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Tests.CollectionTests.InterfacesTests.SelectTests
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
        public void SelectCompileTemplateTest()
        {
            var repository = _repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>())
                .Build<IGuidKeyTestSelectRepository>();
        }

        [Test]
        public void SelectItemTest()
        {
            var itemGuid = Guid.NewGuid();
            var itemValue = "9aa2bx3c";

            var repository = _repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>(new[] { new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = itemGuid, Value = itemValue }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" } }))
                .Build<IGuidKeyTestSelectRepository>();

            var item = repository.Select(itemGuid);

            Assert.That(item.Id, Is.EqualTo(itemGuid));
            Assert.That(item.Value, Is.EqualTo(itemValue));
        }

        [Test]
        public void SelectAllItemsTest()
        {
            var repository = _repositoryBuilder
                .SetSource(new CollectionRepositorySource<GuidKeyTestItem>(new[] { new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" }, new GuidKeyTestItem { Id = Guid.NewGuid(), Value = "fake" } }))
                .Build<IGuidKeyTestSelectRepository>();

            var items = repository.Select();

            Assert.That(items.Length, Is.EqualTo(3));
        }
    }
}
