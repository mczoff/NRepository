using NRepository.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.DemoCollection
{
    public class Song
    {
        [RepositoryKey]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
