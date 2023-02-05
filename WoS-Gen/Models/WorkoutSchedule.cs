using WoS_Gen.Components;

namespace WoS_Gen.Models
{
    public class WorkoutSchedule
    {
        // This method generates a workout plan based on the workoutGoal, location, and experience
        public List<string> GeneratePlan(string workoutGoal, string location, string experience)
        {
            // Initializing an empty list for the workout plan
            List<string> workoutPlan = new List<string>();

            if (workoutGoal == "LoseWeight")
            {
                if (location == "Home")
                {
                    if (experience == "Beginner")
                    {
                        // Adding workout activities for a beginner at home who wants to lose weight, to the workoutPlan list
                        workoutPlan.Add("Cardio (30 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Bodyweight exercises (45 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Yoga (60 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Rest day");
                    }
                    else if (experience == "Novice")
                    {
                        // Adding workout activities for a novice at home who wants to lose weight, to the workoutPlan list
                        workoutPlan.Add("Cardio (30 minutes)");
                        workoutPlan.Add("Bodyweight exercises (45 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Cardio (30 minutes)");
                        workoutPlan.Add("Bodyweight exercises (45 minutes)");
                        workoutPlan.Add("Rest day");
                        workoutPlan.Add("Yoga (60 minutes)");
                    }
                }
                else if (location == "Gym")
                {
                    if (experience == "Beginner")
                    {
                        // Adding workout activities for a beginner at the gym who wants to lose weight, to the workoutPlan list
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
                        // Adding workout activities for a novice at the gym who wants to lose weight, to the workoutPlan list
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
                        // Adding workout activities for a beginner at home who wants to build muscles, to the workoutPlan list
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
                        // Adding workout activities for a novice at home who wants to build muscles, to the workoutPlan list
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
                        // Adding workout activities for a beginner at the gym who wants to build muscles, to the workoutPlan list
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
                        // Adding workout activities for a novice at the gym who wants to build muscles, to the workoutPlan list
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
