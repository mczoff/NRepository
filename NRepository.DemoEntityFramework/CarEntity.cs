using NRepository.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NRepository.DemoEntityFramework
{
    [Table("Cars")]
    public class CarEntity
    {
        [RepositoryKey]
        [Key]
        public int Id { get; set; }

        public string Value { get; set; }
    }
}
