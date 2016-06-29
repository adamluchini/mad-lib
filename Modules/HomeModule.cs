using Nancy;
using MadLib.Objects;

namespace MadLib
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["form.cshtml"];
      };

      Get["/story"]= _ =>{
        FillInVariables myFillInVariables = new FillInVariables();
        myFillInVariables.SetName(Request.Query["name"]);
        myFillInVariables.SetAdjective(Request.Query["adjective"]);
        return View["silly_story.cshtml", myFillInVariables];
      };

    }
  }
}
