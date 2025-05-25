namespace RetailManagementSystem.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public string Description { get; set; }

        // Add these if needed
        public DateTime CreatedDate { get; set; }
        public string Summary { get; set; }
    }
}
