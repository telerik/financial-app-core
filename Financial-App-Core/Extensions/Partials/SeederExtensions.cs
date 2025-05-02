using Financial_App_Core.Models;

namespace Financial_App_Core.Extensions.Partials
{
    public static class SeederExtensions
    {
        public static List<DrawerItemPartialModel> CreateDrawerItem(
            this List<DrawerItemPartialModel> container,
            string displayName = null,
            string id = null,
            string url = null,
            bool isSeparator = false)
        {
            container.Add(new DrawerItemPartialModel
            {
                DisplayName = displayName,
                Id = id,
                Url = url,
                IsSeparator = isSeparator
            });

            return container;
        }

        public static List<MoverPartialModel> CreateMoverItem(
            this List<MoverPartialModel> container,
            string imageUrl,
            string name,
            string abbreviation,
            TrendModel q1,
            TrendModel q2,
            decimal totalEarnings
        )
        {
            container.Add(new MoverPartialModel
            {
                ImageUrl = imageUrl,
                Abbreviation = abbreviation,
                Name = name,
                Q1 = q1,
                Q2 = q2,
                TotalEarnings = totalEarnings
            });

            return container;
        }
    }
}