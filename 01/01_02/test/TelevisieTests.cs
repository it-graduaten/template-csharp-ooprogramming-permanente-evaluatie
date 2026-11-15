using consoleapp.Models;

namespace test;

[TestClass]
[TestCategory("Models")]
public class TelevisieTests
{
    private Televisie _tv = new Televisie();

    [TestMethod]
    public void ToonGegevens_KanaalVolumeInTekst()
    {
        string text = _tv.ToonGegevens();
        StringAssert.Contains(text, "Kanaal: 1");
        StringAssert.Contains(text, "Volume: 5");
        StringAssert.Contains(text, "-");
    }
    [DataTestMethod]
    [DataRow(1, 2)]
    [DataRow(30, 30)]
    public void VermeerderKanaal_KanaalIsGeheelGetal_KanaalIsGeheelGetalPlus1MetMax30(int start, int expected)
    {
        _tv.Kanaal = start;
        _tv.VermeerderKanaal();
        Assert.AreEqual(expected, _tv.Kanaal);
    }

    [DataTestMethod]
    [DataRow(30, 29)]
    [DataRow(2, 1)]
    [DataRow(1, 1)]
    public void VerminderKanaal_KanaalIsGeheelGetal_KanaalIsGeheelGetalMin1MetMin1(int start, int expected)
    {
        _tv.Kanaal = start;
        _tv.VerminderKanaal();
        Assert.AreEqual(expected, _tv.Kanaal);
    }

    [DataTestMethod]
    [DataRow(1, 2)]
    [DataRow(0, 1)]
    [DataRow(10, 10)]
    public void VermeerderVolume_VolumeIsGeheelGetal_VolumeIsGeheelGetalPlus1MetMax10(int start, int expected)
    {
        _tv.Volume = start;
        _tv.VermeerderVolume();
        Assert.AreEqual(expected, _tv.Volume);
    }

    [DataTestMethod]
    [DataRow(10, 9)]
    [DataRow(6, 5)]
    [DataRow(0, 0)]
    public void VerminderVolume_VolumeIsGeheelGetal_VolumeIsGeheelGetalMin1MetMin0(int start, int expected)
    {
        _tv.Volume = start;
        _tv.VerminderVolume();
        Assert.AreEqual(expected, _tv.Volume);
    }
}
