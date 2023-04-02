using System.ComponentModel.DataAnnotations;

namespace Parcial2_GuerraCastroDuban.DAL.Entities
{
    public class Tickets
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime UseDate { get; set; }
        public Boolean IsUsed { get; set; }
        public String EntranceGate { get; set; }
    }
}
