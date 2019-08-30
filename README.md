# NRepository

NRepository is a .NET library for quickly implement a repository pattern 

## Installation

Use the package manager [NuGet](https://www.nuget.org/) to install NRepository.

```bash
```

## Usage

There are several examples of using the library in projects. Examples can be found in demo projects.

Firststep you define model repository:

```C#
class Song
{
    [RepositoryKey]
    public int Id { get; set; }

    public string Value { get; set;}
}
```

Second step you define interface repository:

```C#
interface ISongRepository
     : ISelectRepository<Song, int>, 
       IDeleteRepository<Song, int>, 
       ICreateRepository<Song, int>,
       IUpdateRepository<Song, int>
{
}
```

Third step you can easy create a repository using the repository builder and use it

```C#
...

IRepositoryBuilder repositoryBuilder = new RepositoryBuilder();

var repository = repositoryBuilder
     .SetSource(new CollectionRepositorySource<Song>())
     .Build<ISongRepository>();


var songs = repository.Select();
...
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
