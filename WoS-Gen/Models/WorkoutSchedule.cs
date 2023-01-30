using WoS_Gen.Components;

namespace WoS_Gen.Models
{
    public class WorkoutSchedule
    {
        private string[] muscleGroups = { "Chest", "Back", "Legs", "Shoulders", "Arms", "Abs" };
        private string[] workoutDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public List<string> GeneratePlan(string workoutGoal, string location)
        {
            List<string> workoutPlan = new List<string>();

            if (workoutGoal == "LoseWeight")
            {
                if (location == "Home")
                {
                    workoutPlan.Add("Monday: Cardio (30 minutes)");
                    workoutPlan.Add("Tuesday: Bodyweight exercises (45 minutes)");
                    workoutPlan.Add("Wednesday: Rest day");
                    workoutPlan.Add("Thursday: Cardio (30 minutes)");
                    workoutPlan.Add("Friday: Bodyweight exercises (45 minutes)");
                    workoutPlan.Add("Saturday: Rest day");
                    workoutPlan.Add("Sunday: Yoga (60 minutes)");
                }
                else if (location == "Gym")
                {
                    workoutPlan.Add("Monday: Cardio (30 minutes)");
                    workoutPlan.Add("Tuesday: Strength training (45 minutes)");
                    workoutPlan.Add("Wednesday: Rest day");
                    workoutPlan.Add("Thursday: Cardio (30 minutes)");
                    workoutPlan.Add("Friday: Strength training (45 minutes)");
                    workoutPlan.Add("Saturday: Rest day");
                    workoutPlan.Add("Sunday: Yoga (60 minutes)");
                }
            }
            else if (workoutGoal == "BuildMuscles")
            {
                if (location == "Home")
                {
                    workoutPlan.Add("Monday: Chest and Triceps");
                    workoutPlan.Add("Tuesday: Back and Biceps");
                    workoutPlan.Add("Wednesday: Rest day");
                    workoutPlan.Add("Thursday: Legs and Abs");
                    workoutPlan.Add("Friday: Shoulders and Arms");
                    workoutPlan.Add("Saturday: Rest day");
                    workoutPlan.Add("Sunday: Full-body workout");
                }
                else if (location == "Gym")
                {
                    workoutPlan.Add("Monday: Chest and Triceps");
                    workoutPlan.Add("Tuesday: Back and Biceps");
                    workoutPlan.Add("Wednesday: Rest day");
                    workoutPlan.Add("Thursday: Legs and Abs");
                    workoutPlan.Add("Friday: Shoulders and Arms");
                    workoutPlan.Add("Saturday: Rest day");
                    workoutPlan.Add("Sunday: Full-body workout");
                }
            }

            return workoutPlan;
        }
    }
}
