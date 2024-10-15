namespace ReportsIssue.Models
{
    public class EventCategoryManager
    {
        private HashSet<string> _uniqueCategories = new HashSet<string>();

        // Adds a new category to the HashSet
        public void AddCategory(string category)
        {
            _uniqueCategories.Add(category);
        }

        // Returns the unique categories stored in the HashSet
        public IEnumerable<string> GetUniqueCategories()
        {
            return _uniqueCategories;
        }
    }

}
