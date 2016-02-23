using Xunit;
using System.Collections.Generic;
using System;

namespace Repeat
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_Hello_Equals_1()
    {
      RepeatCounter newSentence = new RepeatCounter();
      Assert.Equal("hello was repeated in hello 1 time(s).", newSentence.CountRepeats("hello", "hello"));
    }
    [Fact]
    public void CountRepeats_Hello_noequal_hi()
    {
      RepeatCounter newSentence = new RepeatCounter();
      Assert.Equal("hello was repeated in hi 0 time(s).", newSentence.CountRepeats("hello", "hi"));
    }
    [Fact]
    public void CountRepeats_Hello_Equals_Lowercase()
    {
      RepeatCounter newSentence = new RepeatCounter();
      Assert.Equal("hello was repeated in HeLLo 1 time(s).", newSentence.CountRepeats("hello", "HeLLo"));
    }
    [Fact]
    public void CountRepeats_You_Equals_RepeatCounter()
    {
      RepeatCounter newSentence = new RepeatCounter();
      Assert.Equal("You was repeated in you You yOU YOU 4 time(s).", newSentence.CountRepeats("You", "you You yOU YOU"));
    }
    [Fact]
    public void CountRepeats_hello_Equals_comma()
    {
      RepeatCounter newSentence = new RepeatCounter();
      Assert.Equal("hello was repeated in hello, hello! 2 time(s).", newSentence.CountRepeats("hello", "hello, hello!"));
    }
  }
}
