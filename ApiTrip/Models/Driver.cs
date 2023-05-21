namespace ApiTrip.Models
{
    public class Driver
    {
        public int driverId { get; set; }
        public string name { get; set; }
        public string licenseNumber { get; set; }
        public ICollection<Trip> trips { get; set; }
    }
}
