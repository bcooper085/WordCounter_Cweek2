using Nancy;
using System;
using System.Collections.Generic;
using Counter.Objects;

namespace Counter
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["index.cshtml"];

            Post["/counter_form"] = _ => {
                RepeatCounter obj = new RepeatCounter(Request.Form["enterSentence"], Request.Form["searchWord"]);
                int output = obj.CountRepeats();
                return View["results.cshtml", output];
            };

        }
    }
}
