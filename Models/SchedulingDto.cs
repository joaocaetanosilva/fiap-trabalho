using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Recycle.Models
{
    public class SchedulingDto
    {
        public int Id { get; set; }
        public DateTime Horario { get; set; }
        public string Bairro { get; set; }
    }
}
