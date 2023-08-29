using Grand.Business.Core.Interfaces.Catalog.Discounts;
using Grand.Business.Core.Utilities.Catalog;
using Grand.Domain.Common;
using Grand.Domain.Customers;
using Grand.Domain.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountRules.Pickup.Providers
{
    public class ShippingPointDiscountRule : IDiscountRule
    {
        //public 

        public string SystemName => "DiscountRules.Pickup.ShippingPointDeliveryIsSelected";

        public string FriendlyName => "Selected shipping point delivery";

        public Task<DiscountRuleValidationResult> CheckRequirement(DiscountRuleValidationRequest request)
        {
            var result = new DiscountRuleValidationResult();

            var shippingOption = request.Customer.GetUserFieldFromEntity<ShippingOption>(SystemCustomerFieldNames.SelectedShippingOption, request.Store.Id);
            if (shippingOption != null)
            {
                //details.ShippingMethodName = shippingOption.Name;
                //details.ShippingRateProviderSystemName = shippingOption.ShippingRateProviderSystemName;
                if (shippingOption.ShippingRateProviderSystemName == "Shipping.ShippingPoint")
                    result.IsValid = true;
            }

            return Task.FromResult(result);
        }

        public string GetConfigurationUrl(string discountId, string discountRequirementId)
        {
            //configured 
            var result = "Admin/PickupDiscount/Configure/?discountId=" + discountId;
            if (!string.IsNullOrEmpty(discountRequirementId))
                result += $"&discountRequirementId={discountRequirementId}";
            return result;
        }
    }
}