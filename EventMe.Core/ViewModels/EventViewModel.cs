using System.ComponentModel.DataAnnotations;
using static EventMe.Core.Constants.ErrorMessages;
using static EventMe.Core.Constants.ValidationConstans;

namespace EventMe.Core.ViewModels
{
    /// <summary>
    ///     Event view model
    /// </summary>
    public class EventViewModel
    {
        /// <summary>
        ///     Event identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Event name
        /// </summary>
        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = LengthErrorMessage)]
        public required string Name { get; set; }

        /// <summary>
        ///     Event start date and time
        /// </summary>
        [Required(ErrorMessage = RequireErrorMessage)]
        public required DateTime Start { get; set; }

        /// <summary>
        ///     Event end date and time
        /// </summary>
        [Required(ErrorMessage = RequireErrorMessage)]
        public required DateTime End { get; set; }

        /// <summary>
        ///     Event place
        /// </summary>
        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(PlaceMaxLength, MinimumLength = PlaceMinLength, ErrorMessage = LengthErrorMessage)]
        public required string Place { get; set; }
    }
}
