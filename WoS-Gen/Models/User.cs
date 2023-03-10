namespace WoS_Gen.Models
{
    public class User
    {
        // Properties for name, email, workoutgoal, location and experience
        public string Name { get; set; }
        public string Email { get; set; }
        public string WorkoutGoal { get; set; }
        public string Location { get; set; }
        public string Experience { get; set; }

        // Constructor to initialize a user object with name, email, workout goal, location, and experience
        public User(string userName, string email, string workoutGoal, string location, string experience)
        {
            Name = userName;
            Email = email;
            WorkoutGoal = workoutGoal;
            Location = location;
            Experience = experience;
        }
    }
}
