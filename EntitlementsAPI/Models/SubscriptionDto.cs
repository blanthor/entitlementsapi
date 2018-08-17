namespace EntitlementsAPI.Models
{
    public class SubscriptionDto
    {
        public int Id { get; set; }
        public int LicenseId { get; set; }
        public string Resource { get; set; }
        public int Capacity { get; set; }

    }
}
