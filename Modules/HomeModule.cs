using Nancy;
using System;
using RepeatCounter;

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
        Sentence newSentence = new Sentence();
        string results = newSentence.Count(Request.Form["word"], Request.Form["sentence"]);
        return View["result.cshtml", results];
      };
    }
  }
}
