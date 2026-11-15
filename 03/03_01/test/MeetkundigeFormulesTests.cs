using consoleapp.Models;

namespace test;

[TestClass]
[TestCategory("Models")]

public class MeetkundigeFormulesTests
{

    [TestMethod]
    public void OppervlakteRechthoek_ReturnTypeIsDouble()
    {
        var output = MeetkundigeFormules.OppervlakteRechthoek(4, 5);
        Assert.IsInstanceOfType(output, typeof(double));
    }


    [TestMethod]
    public void OppervlakteCirkel_ReturnTypeIsDouble()
    {
        var output = MeetkundigeFormules.OppervlakteCirkel(4);
        Assert.IsInstanceOfType(output, typeof(double));
    }


    [TestMethod]
    public void VolumeBalk_ReturnTypeIsDouble()
    {
        var output = MeetkundigeFormules.VolumeBalk(4, 5, 10);
        Assert.IsInstanceOfType(output, typeof(double));
    }


    [TestMethod]
    public void VolumeCilinder_ReturnTypeIsDouble()
    {
        var output = MeetkundigeFormules.VolumeCilinder(4, 10);
        Assert.IsInstanceOfType(output, typeof(double));
    }


    [TestMethod]
    public void OppervlakteRechthoek_LengteBreedte_UitkomstCorrect()
    {
        var output = MeetkundigeFormules.OppervlakteRechthoek(4, 5);
        Assert.AreEqual(20, output, 1);
    }


    [TestMethod]
    public void OppervlakteCirkel_Straal_UitkomstCorrect()
    {
        var output = MeetkundigeFormules.OppervlakteCirkel(4);
        double waarde = Math.PI * 4 * 4;
        Assert.AreEqual(waarde, output, 1);
    }


    [TestMethod]
    public void VolumeBalk_LengteBreedteHoogte_UitkomstCorrect()
    {
        var output = MeetkundigeFormules.VolumeBalk(4, 5, 10);
        Assert.AreEqual(200, output, 1);
    }


    [TestMethod]
    public void VolumeCilinder_StraalHoogte_UitkomstCorrect()
    {
        var output = MeetkundigeFormules.VolumeCilinder(4, 10);
        double w = Math.PI * 4 * 4 * 10;
        Assert.AreEqual(w, output, 1);
    }
}

