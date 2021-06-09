using System;
using System.Collections.Generic;
using System.Linq;

namespace JewelryStore.BL
{
    public static class DiscountInfo
    {
        private static List<string> allowedCategories;

        private static decimal discountValue;

        static DiscountInfo()
        {
            allowedCategories = Resource.Allowedcategories.Split(',').ToList();
            decimal.TryParse(Resource.Discount, out discountValue);
        }

        public static bool IsDiscountApplicable(string categoryName)
        {
            return allowedCategories.Contains(categoryName);
        }
        public static decimal GetDiscountNumber(string categoryName)
        {
            if (IsDiscountApplicable(categoryName))
            {
                return discountValue;
            }
            else return 0;
        }
    }
}
