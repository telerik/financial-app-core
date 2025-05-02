using Microsoft.AspNetCore.Mvc;

using Financial_App_Core.Extensions.Partials;
using Financial_App_Core.Models;

namespace Financial_App_Core.Seeders
{
    public static class FinancialSeeder
    {
        public static IEnumerable<DrawerItemPartialModel> SeedDrawerItems(IUrlHelper url)
        {
            var container = new List<DrawerItemPartialModel>();

            container
                .CreateDrawerItem(isSeparator: true)
                .CreateDrawerItem(
                    displayName: "Home",
                    id: "home",
                    url: url.Action("Index", "Home")
                )
                .CreateDrawerItem(
                    displayName: "Transactions",
                    id: "transactions",
                    url: url.Action("Transactions", "Home")
                )
                .CreateDrawerItem(
                    displayName: "Investments",
                    id: "investments",
                    url: url.Action("Investments", "Home")
                )
                .CreateDrawerItem(
                    displayName: "Analytics",
                    id: "analytics",
                    url: url.Action("Analytics", "Home")
                )
                .CreateDrawerItem(
                    displayName: "AI Assistant",
                    id: "aiassistant",
                    url: url.Action("AiAssistant", "Home")
                )
                .CreateDrawerItem(isSeparator: true)
                .CreateDrawerItem(
                    displayName: "Settings",
                    id: "settings",
                    url: url.Action("Settings", "Home")
                );

            return container;
        }

        public static IEnumerable<MoverPartialModel> SeedMovers(IUrlHelper url)
        {
            var container = new List<MoverPartialModel>();

            container
                .CreateMoverItem(
                    imageUrl: url.Content("~/images/BITCOIN.svg"),
                    name: "Bitcoin",
                    abbreviation: "BTC",
                    q1: new TrendModel { Earning = 145.25M, Difference = 0.40, IsNegative = true, Percent = 47 },
                    q2: new TrendModel { Earning = 145.25M, Difference = 0.40, IsNegative = true, Percent = 47 },
                    totalEarnings: 95.887M
                )
                .CreateMoverItem(
                    imageUrl: url.Content("~/images/ETHERIUM.svg"),
                    name: "Etherium",
                    abbreviation: "ETH",
                    q1: new TrendModel { Earning = 250.23M, Difference = 0.50, IsNegative = false, Percent = 86 },
                    q2: new TrendModel { Earning = 145.25M, Difference = 0.40, IsNegative = true, Percent = 47 },
                    totalEarnings: 24.764M
                )
                .CreateMoverItem(
                    imageUrl: url.Content("~/images/xrp.svg"),
                    name: "Ripple",
                    abbreviation: "XRP",
                    q1: new TrendModel { Earning = 590.25M, Difference = 0.40, IsNegative = true, Percent = 47 },
                    q2: new TrendModel { Earning = 360.21M, Difference = 0.50, IsNegative = false, Percent = 86 },
                    totalEarnings: 15.007M
                )
                .CreateMoverItem(
                    imageUrl: url.Content("~/images/TETHERUS.svg"),
                    name: "Theter",
                    abbreviation: "TTH",
                    q1: new TrendModel { Earning = 190.45M, Difference = 0.50, IsNegative = false, Percent = 86 },
                    q2: new TrendModel { Earning = 365.32M, Difference = 0.40, IsNegative = true, Percent = 47 },
                    totalEarnings: 76.123M
                )
                .CreateMoverItem(
                    imageUrl: url.Content("~/images/INCH.svg"),
                    name: "Unicorn",
                    abbreviation: "UNI",
                    q1: new TrendModel { Earning = 750.54M, Difference = 0.50, IsNegative = false, Percent = 86 },
                    q2: new TrendModel { Earning = 421.89M, Difference = 0.50, IsNegative = true, Percent = 86 },
                    totalEarnings: 30.456M
                );

            return container;
        }
    }
}
