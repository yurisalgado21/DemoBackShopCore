using System.ComponentModel.DataAnnotations;
using DemoBackShopCore.Utils;
using DemoBackShopCore.Models;
using DemoBackShopCore.Utils;

namespace DemoBackShopCore.DTOs
{
    public class CustomerRequestDTO
    {
        [Required(ErrorMessage = DomainResponseMessages.FirstNameIsRequired)]
        [MaxLength(length: CustomerConstantsRules.MAXIMUM_CHARACTERS_FIRST_NAME , ErrorMessage = DomainResponseMessages.MaximumOf40CharactersError)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = DomainResponseMessages.LastNameIsRequired)]
        [MaxLength(length: CustomerConstantsRules.MAXIMUM_CHARACTERS_LAST_NAME, ErrorMessage = DomainResponseMessages.MaximumOf40CharactersError)]
        public string LastName { get; set; }
        [Required(ErrorMessage = DomainResponseMessages.EmailAddressIsRequired)]
        [EmailAddress(ErrorMessage = DomainResponseMessages.EmailFieldIsNotAValid)]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = DomainResponseMessages.DateOfBirthIsRequired)]
        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }
    }
}