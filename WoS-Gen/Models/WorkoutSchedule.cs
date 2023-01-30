using WoS_Gen.Components;

namespace WoS_Gen.Models
{
    public class WorkoutSchedule
    {
        private string[] muscleGroups = { "Chest", "Back", "Legs", "Shoulders", "Arms", "Abs" };
        private string[] workoutDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public Dictionary<string, string[]> schedule = new Dictionary<string, string[]>();
        
        public WorkoutSchedule(User user)
        {
            GenerateSchedule(user);
        }
        
        public void GenerateSchedule(User user)
        {
            if (user.WorkoutGoal == "LoseWeight")
            {
                if (user.Location == "Home")
                {

                }
                else if (user.Location == "Gym")
                {

                }
            }
            else if (user.WorkoutGoal == "BuildMuscles")
            {
                if (user.Location == "Home")
                {

                }
                else if (user.Location == "Gym")
                {

                }
            }
        }
    }
}
