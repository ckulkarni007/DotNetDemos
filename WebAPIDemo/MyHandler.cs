using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WebAPIDemo
{
    public class AuthtenticationHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var authPara = request.Headers.Authorization.Parameter;
            string credentials = Encoding.UTF8.GetString(Convert.FromBase64String(authPara));
            request.Headers.TryGetValues("username", out IEnumerable<string> userNames);
            request.Headers.TryGetValues("authorization", out IEnumerable<string> passwords);

            //DB Call

            string userName = ""; string password = "";
            if (userNames != null && passwords != null)
            {
                userName = userNames.FirstOrDefault();
                password = passwords.FirstOrDefault();
            }
            else
            {
                var credSplit = credentials.Split(':');
                userName = credSplit[0];
                password = credSplit[1];
            }

            if (userName != "chaitanya" && password != "Newuser123")
            {
                var Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
                Response.Content = new StringContent("You are not valid user for this webapi");
                return Task.FromResult(Response);
            }

            //Debug.Write($"you want to know the url you are hitting  - {actionContext.Request.RequestUri}");

            MyPrincipal myPrincipal = new MyPrincipal(new GenericIdentity("userIdentity"), new string[] { "admin" , "teacher","HR","accountant"});
            Thread.CurrentPrincipal = myPrincipal;
            HttpContext.Current.User = myPrincipal;
            return base.SendAsync(request, cancellationToken);
        }
    }

    public class MyPrincipal : GenericPrincipal
    {
        public MyPrincipal(IIdentity identity, string[] roles)
            : base(identity, roles)
        {
        }
    }

}