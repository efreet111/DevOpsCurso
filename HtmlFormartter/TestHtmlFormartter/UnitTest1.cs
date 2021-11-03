using NUnit.Framework;
using HtmlFormartter;

namespace TestHtmlFormartter
{
  public class Tests
  {
    private HtmlFormarter _HtmlFormartter;

    [SetUp]
    public void Setup()
    {
      _HtmlFormartter = new HtmlFormarter();
    }


    [Test]
    public void HtmlFormarter_is_not_Empty()
    {
      //Assert.IsNotEmpty(_HtmlFormartter.FormatAsBold);

      Assert.That( _HtmlFormartter.FormatAsBold(string.Empty), Is.Not.Empty);
    }


    [Test]
    public void HtmlFormarter_is_Html_Format()
    {
      
      Assert.Contains(_HtmlFormartter.FormatAsBold, valor);
    }
  }
}