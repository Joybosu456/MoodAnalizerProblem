using Microsoft.VisualStudio.TestTools.UnitTesting;

using MoodAnalyzerProblem;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class MoodAnlyzerTest
    {/// <summary>
    /// 
    /// UC1-Joy(TC-1.1)
    /// </summary>
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            // Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse();

            // Act
            string mood = moodAnalyse.AnalyseMood(message);

            // Assert
            Assert.AreEqual(expected, mood);
        }
    }

    [TestMethod]
    public void GivenAnyMoodReturnHAPPY()
    {
        /// <summary>
        /// TC 1.2: Given “I am in Any Mood” message Should Return HAPPY
        /// </summary>
        /// 
        // Arrange
        string expected = "HAPPY";
        string message = "I am in Any Mood";
        MoodAnalyse moodAnalyse = new MoodAnalyse();

        // Act
        string mood = moodAnalyse.AnalyseMood(message);

        // Assert
        Assert.AreEqual(expected, mood);
    }
}
