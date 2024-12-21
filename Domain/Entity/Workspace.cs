
using Domain.Enum;

namespace Domain.Entity
{
    public class Workspace
    {
        public Guid Id { get; set; }
        public string? TItle { get; set; }
        public User? User { get; set; }
        public ICollection<ListCard>? ListsCard { get; set; }
        public StatusItemEnum Status {  get; set; }
        public DateTime CreatedAt  { get; set; } = DateTime.Now;
    }
}
