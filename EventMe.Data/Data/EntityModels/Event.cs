using static EventMe.Data.Constants.EntityValidationConstants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventMe.Data.Data.EntityModels
{
    [Comment("Table with events")]
    public class Event
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Comment("Event identifier")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(EventNameMaxLength)]
        [Comment("Event name")]
        public required string Name { get; set; }

        [Required]
        [Comment("Event start")]
        public required DateTime Start {  get; set; }

        [Required]
        [Comment("Event end")]
        public required DateTime End { get; set; }

        [Required]
        [Comment("Place for event")]
        public required string Place { get; set; }

        [Required]
        [Comment("Active status")]
        public bool IsDeleted { get; set; } = false;
    }
}
