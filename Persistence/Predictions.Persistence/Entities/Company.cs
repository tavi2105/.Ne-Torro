using System.ComponentModel.DataAnnotations.Schema;

namespace Predictions.Persistence.Entities
{
    public class Company
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
