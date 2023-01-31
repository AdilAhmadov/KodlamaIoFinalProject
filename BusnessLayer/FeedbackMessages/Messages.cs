namespace BusnessLayer.FeedbackMessages
{
    public class Messages
    {
        public static string ProductAdded = "Prodoct Added";
        public static string ProductListed = "Products are listed";
        public static string ProductNameInValid = "Product Name is Invalid";
        public static string SystemMaintenaceTime = "System in maintenace mode";

        public static string CategoryAdded = "Category Added";
        public static string CategoryDeleted = "Category deleted";
        public static string CategoryUpdated = "Category updated";

        public static string CategoriesListed = "Categories are listed";

        public static string? ProductDeleted = "Product Deleted";
        public static string? ProductUpdated = "Product Updated";

        public static string? CategoryWithIDListed(int id)
        {
            return $"Category with {id} listed";
        }
        public static string? ProductWithIDListed(int id)
        {
            return $"Product with {id} listed";
        }
    }
}
