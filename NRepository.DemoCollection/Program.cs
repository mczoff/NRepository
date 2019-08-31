using NRepository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.DemoCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepositoryBuilder repositoryBuilder = new RepositoryBuilder();

            var repository = repositoryBuilder
                .SetSource(new CollectionRepositorySource<Song>())
                .Build<ISongRepository>();

            repository.Create(new Song { Id = 0, Name = "Agata Resx - Download my source code" });
            repository.Create(new Song { Id = 1, Name = "Agata Resx - Comment me" });
            repository.Create(new Song { Id = 2, Name = "Agata Resx - Star" });
            repository.Create(new Song { Id = 3, Name = "Agata Resx - Men" });

            var songs = repository.SelectPage(1, 2);
        }
    }
}
