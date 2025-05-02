using Kendo.Mvc.Extensions;

namespace Financial_App_Core.Models
{
    public class DrawerItemPartialModel
    {
        public string DisplayName
        {
            get;
            set;
        }
        public string Id
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }

        public bool IsSeparator
        {
            get;
            set;
        }
    }
}
