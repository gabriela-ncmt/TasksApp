﻿
using Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Workspace
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(45, MinimumLength = 2)]
        public string? TItle { get; set; }
        [Required]
        public User? User { get; set; }
        public ICollection<ListCard>? ListsCard { get; set; }
        public StatusItemEnum Status {  get; set; } = StatusItemEnum.Active;
        public DateTime CreatedAt  { get; set; } = DateTime.Now;
    }
}
