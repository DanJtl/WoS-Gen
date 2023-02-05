using WoS_Gen.Models;

namespace Wos_Gen_xUnit_Test
{
    public class UserTests
    {
        [Fact]
        public void ConstructorSetProperties()
        {
            // Arrange
            string fullName = "Kalle Anka";
            string email = "kalle@anka.com";
            string workoutGoal = "Lose Weight";
            string location = "Home";
            string experience = "Novice";

            // Act
            User user = new User(fullName, email, workoutGoal, location, experience);

            // Assert
            Assert.Equal(fullName, user.Name);
            Assert.Equal(email, user.Email);
            Assert.Equal(workoutGoal, user.WorkoutGoal);
            Assert.Equal(location, user.Location);
            Assert.Equal(experience, user.Experience);
        }
    }
}
