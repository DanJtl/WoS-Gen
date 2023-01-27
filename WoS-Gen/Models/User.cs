namespace WoS_Gen.Models
{
    public class User
    {
        // Properties for name, email, workoutgoal and location
        public string Name { get; set; }
        public string Email { get; set; }
        public string WorkoutGoal { get; set; }
        public string Location { get; set; }

        // Constructor to initialize user's name, email, workoutgoal and location
        public User(string name, string email, string workoutGoal, string location)
        {
            Name = name;
            Email = email;
            WorkoutGoal = workoutGoal;
            Location = location;
        }

    }
}
