using FluentAssertions;

namespace variable.Test;

public class UnitTest1
{
  [Theory(DisplayName = "Convert.ToInt32(string)")]
  [InlineData("42", 42)]
  [InlineData("-42", -42)]
  [InlineData("200", 200)]
  public void TestVariableConversion(string entry, int expected)
  {
    Class1 instance = new();

    instance.strEntry = entry;
    var strTypeCheck = instance.strEntry is string;
    strTypeCheck.Should().BeTrue();

    instance.DoConversion();

    instance.intResponse.Should().Be(expected);
    var intTypeCheck = instance.intResponse is int;
    intTypeCheck.Should().BeTrue();

  }
}