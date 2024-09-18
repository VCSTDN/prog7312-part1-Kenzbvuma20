namespace ReportsIssue.Models
{
    public class MainMenuViewModel
    {



        public IEnumerable<MenuItem> MenuOptions { get; set; }
        public IEnumerable<ReportIssueViewModel> ReportIssues { get; set; }

    }
}
