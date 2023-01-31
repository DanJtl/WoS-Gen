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
                        workoutPlan.Add("Monday: Cardio (30 minutes)");
                        workoutPlan.Add("Tuesday: Rest day");
                        workoutPlan.Add("Wednesday: Bodyweight exercises (45 minutes)");
                        workoutPlan.Add("Thursday: Rest day");
                        workoutPlan.Add("Friday: Yoga (60 minutes)");
                        workoutPlan.Add("Saturday: Rest day");
                        workoutPlan.Add("Sunday: Rest day");
                    }
                    else if (experience == "Novice")
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
                    if (experience == "Beginner")
                    {
                        workoutPlan.Add("Monday: Cardio (30 minutes)");
                        workoutPlan.Add("Tuesday: Rest day");
                        workoutPlan.Add("Wednesday: Yoga (60 minutes)");
                        workoutPlan.Add("Thursday: Rest day");
                        workoutPlan.Add("Friday: Strength training (45 minutes)");
                        workoutPlan.Add("Saturday: Rest day");
                        workoutPlan.Add("Sunday: Rest day");
                    }
                    else if (experience == "Novice")
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
            }
            else if (workoutGoal == "BuildMuscles")
            {
                if (location == "Home")
                {
                    if (experience == "Beginner")
                    {
                        workoutPlan.Add("Monday: Upper-body workout");
                        workoutPlan.Add("Tuesday: Rest day");
                        workoutPlan.Add("Wednesday: Lower-body workout");
                        workoutPlan.Add("Thursday: Rest day");
                        workoutPlan.Add("Friday: Full-body workout");
                        workoutPlan.Add("Saturday: Rest day");
                        workoutPlan.Add("Sunday: Rest day");
                    }
                    else if (experience == "Novice")
                    {
                        workoutPlan.Add("Monday: Upper-body workout");
                        workoutPlan.Add("Tuesday: Lower-body workout");
                        workoutPlan.Add("Wednesday: Rest day");
                        workoutPlan.Add("Thursday: Upper-body workout");
                        workoutPlan.Add("Friday: Lower-body workout");
                        workoutPlan.Add("Saturday: Rest day");
                        workoutPlan.Add("Sunday: Full-body workout");
                    }
                }
                else if (location == "Gym")
                {
                    if (experience == "Beginner")
                    {
                        workoutPlan.Add("Monday: Chest, Shoulders and Triceps");
                        workoutPlan.Add("Tuesday: Rest day");
                        workoutPlan.Add("Wednesday: Back, Abs and Biceps");
                        workoutPlan.Add("Thursday: Rest day");
                        workoutPlan.Add("Friday: Leg day");
                        workoutPlan.Add("Saturday: Rest day");
                        workoutPlan.Add("Sunday: Rest day");
                    }
                    else if (experience == "Novice")
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
            }
            return workoutPlan;
        }
    }
}
