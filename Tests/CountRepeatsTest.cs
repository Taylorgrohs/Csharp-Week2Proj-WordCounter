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
    [Fact]
    public void Count_You_Equals_Sentence()
    {
      Sentence newSentence = new Sentence();
      Assert.Equal("You was repeated in you You yOU YOU 4 time(s).", newSentence.Count("You", "you You yOU YOU"));
    }
    [Fact]
    public void Count_hello_Equals_comma()
    {
      Sentence newSentence = new Sentence();
      Assert.Equal("hello was repeated in hello, hello! 2 time(s).", newSentence.Count("hello", "hello, hello!"));
    }
  }
}
