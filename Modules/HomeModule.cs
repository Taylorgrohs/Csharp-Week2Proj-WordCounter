using Nancy;
using System;
using Repeat;

namespace GetCounting
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
      Post["/result"] = _ =>
      {
        RepeatCounter newSentence = new RepeatCounter();
        string results = newSentence.CountRepeats(Request.Form["word"], Request.Form["sentence"]);
        return View["result.cshtml", results];
      };
    }
  }
}
