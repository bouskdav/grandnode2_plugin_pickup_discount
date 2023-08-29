using Grand.Infrastructure.ModelBinding;
using Grand.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DiscountRules.Pickup.Models
{
    public class RequirementModel
    {
        public RequirementModel()
        {
            //AvailableCustomerGroups = new List<SelectListItem>();
        }

        //[GrandResourceDisplayName("Plugins.DiscountRules.Pickup.Fields.CustomerGroup")]
        //public string CustomerGroupId { get; set; }

        public string DiscountId { get; set; }

        public string RequirementId { get; set; }

        //public IList<SelectListItem> AvailableCustomerGroups { get; set; }
    }
}