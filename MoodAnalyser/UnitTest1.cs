
namespace MoodAnalyser
{

    public class UnitTest1
    {
        /// <summary>
        /// tc 1.1 I am in sad mood message should return sad 
        /// </summary>
        public void GivenMoodshouldReturnSad()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad mood";
            moodAnalyze moodAnalyze = new moodAnalyze(message);

            //Act
            string mood = moodAnalyze.Analyzemood();

            //Assert
            Assert.AreEqual(expected, mood);

            /// <summary>
            /// TC 1.2 & 2.1 : Given ? I am in HAPPY Mood? and null should return Happy     
            /// </summary>

            [TestMethod]
            ///[DataRow ("I am in Happy Mood")]
            [DataRow(null)]


            public void GivenHAPPYMoodShouldReturnHappy(string message)
            {
                //Arrange
                string expected = "HAPPY":
                    MoodAnalyser moodAnalyser = new MoodAnalyser(messsage);

            //Act
            string mood = moodAnalyser.AnalyseMethod();

            //Assert 
            Assert.AreEquAl(expected, mood);


            /// <summary>
            /// Tc 3.1 : Given ? NULL_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood 
            /// </summary>

            publiv void Given_NULL_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
            {
                try
                {
                    string message = "null";
                    MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                    string mood = moodAnalyse.AnalyseMood();
                }
                catch
                {
                    Assert.AreEqual("Mood Should not be Null", e.message);
                }

                /// <summary>
                /// Tc 3.2 : Given ? Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood 
                /// </summary>
                public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
            {
                try
                {
                    string message = " ";
                    MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                    string mood = moodAnalyse.AnalyseMood();
                }
                catch
                {
                    Assert.AreEqual("Mood Should not be Empty", e.message);
                }


            }
        }
    }
}
