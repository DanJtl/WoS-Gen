using WoS_Gen.Models;

namespace Wos_Gen_xUnit_Test
{
    public class WorkoutScheduleTests
    {
        [Fact]
        public void GeneratePlanLoseWeightHomeBeginner()
        {
            // Arrange
            var workoutSchedule = new WorkoutSchedule();
            var expectedWorkoutPlan = new List<string>
        {
            "Cardio (30 minutes)",
            "Rest day",
            "Bodyweight exercises (45 minutes)",
            "Rest day",
            "Yoga (60 minutes)",
            "Rest day",
            "Rest day"
        };

            // Act
            var workoutPlan = workoutSchedule.GeneratePlan("LoseWeight", "Home", "Beginner");

            // Assert
            Assert.Equal(expectedWorkoutPlan, workoutPlan);
        }
    }
}
