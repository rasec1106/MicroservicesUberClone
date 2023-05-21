using System.Net.NetworkInformation;

namespace ApiTrip.Models
{
    public class Trip
    {
        public int tripId { get; set; }
        public int userId { get; set; }
        public int driverId { get; set; }
        public string? pickupLocation { get; set; }
        public string? destinationLocation { get; set; }
        public DateTime pickupTime { get; set; }
        public TripStatus status { get; set; }
        public Driver? driver { get; set; }
        public User? user { get; set; }
    }

    public enum TripStatus
    {
        Pending,
        InProgress,
        Completed,
        Cancelled
    }
}
