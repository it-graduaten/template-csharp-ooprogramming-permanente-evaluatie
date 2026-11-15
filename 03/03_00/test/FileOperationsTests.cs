using consoleapp.Models;

namespace test;

[TestClass]
[TestCategory("Models")]
public class FileOperationsTests
{
    
    [TestMethod]
    public void BestandStudenten_HeeftCorrecteWaarde()
    {
        Assert.AreEqual("studenten.txt", FileOperations.BestandStudenten);
    }

    
    [TestMethod]
    public void BestandScores_HeeftCorrecteWaarde()
    {
        Assert.AreEqual("scores.txt", FileOperations.BestandScores);
    }

    
    [TestMethod]
    public void StudentenLezen_ReturntLijstVanStrings()
    {
        Assert.IsInstanceOfType(FileOperations.StudentenLezen(), typeof(List<string>));
    }


    [TestMethod]
    public void ScoresLezen_ReturntLijstVanInts()
    {
        Assert.IsInstanceOfType(FileOperations.ScoresLezen(), typeof(List<int>));
    }

    
    [TestMethod]
    public void StudentenLezen_LijstBevatStudenten()
    {
        List<string> studenten = FileOperations.StudentenLezen();
        Assert.IsTrue(studenten.Any());
    }

    
    [TestMethod]
    public void ScoresLezen_LijstBevatScores()
    {
        List<int> scores = FileOperations.ScoresLezen();
        Assert.IsTrue(scores.Any());
    }
}