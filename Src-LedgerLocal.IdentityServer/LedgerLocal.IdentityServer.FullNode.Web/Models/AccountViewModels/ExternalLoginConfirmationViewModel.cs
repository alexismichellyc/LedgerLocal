using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LedgerLocal.IdentityServer.FullNode.Web.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "God Father Id")]
        public string GodFatherId { get; set; }

        [Display(Name = "Terms and Conditions")]
        public bool IsAgree { get; set; }
    }
}
