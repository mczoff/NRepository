using NRepository.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.DemoEntityFramework
{
    public class Car
    {
        [RepositoryKey]
        public int Id { get; set; }

        public string Value { get; set; }
    }
}
