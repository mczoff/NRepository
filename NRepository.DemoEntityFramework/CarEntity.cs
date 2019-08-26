using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.DemoEntityFramework
{
    public class CarEntity
    {
        [Key]
        public int Id { get; set; }

        public string Value { get; set; }
    }
}
