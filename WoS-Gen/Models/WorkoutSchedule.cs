using WoS_Gen.Components;

namespace WoS_Gen.Models
{
    public class WorkoutSchedule
    {
        public List<string> GeneratePlan(string workoutGoal, string location, string experience)
        {
            List<string> workoutPlan = new List<string>();

            if (workoutGoal == "LoseWeight")
            {
                if (location == "Home")
                {
                    if (experience == "Beginner")
                    {
                        workoutPlan.Add("Cardio (30 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Bodyweight exercises (45 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Yoga (60 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Rest day");
                    }
                    else if (experience == "Novice")
                        workoutPlan.Add("Cardio (30 minutes)");
                        workoutPlan.Add("Bodyweight exercises (45 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Cardio (30 minutes)");
                        workoutPlan.Add("Bodyweight exercises (45 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Yoga (60 minutes)");
                }
                else if (location == "Gym")
                {
                    if (experience == "Beginner")
                    {
                        workoutPlan.Add("Cardio (30 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Yoga (60 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Strength training (45 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Rest day");
                    }
                    else if (experience == "Novice")
                    {
                        workoutPlan.Add("Cardio (30 minutes)");
                        workoutPlan.Add("Strength training (45 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Cardio (30 minutes)");
                        workoutPlan.Add("Strength training (45 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Yoga (60 minutes)");
                    }
                }
            }
            else if (workoutGoal == "BuildMuscles")
            {
                if (location == "Home")
                {
                    if (experience == "Beginner")
                    {
                        workoutPlan.Add("Upper-body workout");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Lower-body workout");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Full-body workout");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Rest day");
                    }
                    else if (experience == "Novice")
                    {
                        workoutPlan.Add("Upper-body workout");
                        workoutPlan.Add("Lower-body workout");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Upper-body workout");
                        workoutPlan.Add("Lower-body workout");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Full-body workout");
                    }
                }
                else if (location == "Gym")
                {
                    if (experience == "Beginner")
                    {
                        workoutPlan.Add("Chest, Shoulders and Triceps");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Back, Abs and Biceps");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Leg day");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Rest day");
                    }
                    else if (experience == "Novice")
                    {
                        workoutPlan.Add("Chest and Triceps");
                        workoutPlan.Add("Back and Biceps");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Legs and Abs");
                        workoutPlan.Add("Shoulders and Arms");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Full-body workout");
                    }
                }
            }
            return workoutPlan;
        }
    }
}
