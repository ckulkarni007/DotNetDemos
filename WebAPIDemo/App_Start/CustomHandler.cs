using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo
{
    public class CustomHandler : IHttpHandler
    {
        public readonly static IEnumerable<Team> MyTeams = new List<Team>
    {
        new Team { City = "Philadelphia", Name = "Phillies" },
        new Team { City = "Boston", Name = "Red Sox" },
        new Team { City = "Cleveland", Name = "Browns" },
        new Team { City = "Houston", Name = "Astros" },
        new Team { City = "San Diego", Name = "Chargers" }
    };

        #region IHttpHandler Members

        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/xml";

            context.Response.Write("<teams>");

            foreach (var t in MyTeams)
            {
                context.Response.Write("<team>");
                context.Response.Write("<city>");
                context.Response.Write(t.City);
                context.Response.Write("</city>");
                context.Response.Write("<name>");
                context.Response.Write(t.Name);
                context.Response.Write("</name>");
                context.Response.Write("</team>");
            }

            context.Response.Write("</teams>");

        }

        #endregion
    }

    public class Team
    {
        public string City { get; internal set; }
        public string Name { get; internal set; }
    }
}