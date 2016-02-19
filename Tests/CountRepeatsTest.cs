using Xunit;
using System.Collections.Generic;
using System;

namespace RepeatCounter
{
  public class RepeatCountTest
  {
    [Fact]
    public void Count_Hello_Equals_1()
    {
      Sentence newSentence = new Sentence();
      Assert.Equal("hello was repeated in hello 1 time(s).", newSentence.Count("hello", "hello"));
    }
    [Fact]
    public void Count_Hello_Equals_Lowercase()
    {
      Sentence newSentence = new Sentence();
      Assert.Equal("hello was repeated in HeLLo 1 time(s).", newSentence.Count("hello", "HeLLo"));
    }
  }
}
