namespace ReportsIssue.Models
{
    public class SearchTracker
    {
        private Dictionary<string, int> _searchCounts = new Dictionary<string, int>();

        public void TrackSearch(string category)
        {
            if (_searchCounts.ContainsKey(category))
            {
                _searchCounts[category]++;
            }
            else
            {
                _searchCounts[category] = 1;
            }
        }

        public string GetMostSearchedCategory()
        {
            return _searchCounts.OrderByDescending(c => c.Value).FirstOrDefault().Key;
        }
    }

}
