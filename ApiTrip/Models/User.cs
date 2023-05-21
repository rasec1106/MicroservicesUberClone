namespace ApiTrip.Models
{
    public class User
    {
        public int userId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public ICollection<Trip> trips { get; set; }
    }
}
