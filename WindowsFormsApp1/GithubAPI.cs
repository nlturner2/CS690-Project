using System;
using Octokit;
using Octokit.Reactive;
using System.Net;
using System.Threading.Tasks;
using RestEase;
using System.Reactive.Linq;

namespace WindowsFormsApp1
{
    public class GithubAPI
    {
        /*public GithubAPI()
         {

             var githubToken = "84829a0f70155da53e96bd51506836d1db226e9d";
             var request = (HttpWebRequest)WebRequest.Create("https://api.github.com/repos/nlturner2/CS690-Project");
             request.Headers.Add(HttpRequestHeader.Authorization, string.Concat("token ", githubToken));
             request.Accept = "application/vnd.github.v3.raw";
             request.UserAgent = "nlturner2/CS690-Project"; //user agent is required https://developer.github.com/v3/#user-agent-required
             using (var response = request.GetResponse())
             {
                 var encoding = System.Text.ASCIIEncoding.UTF8;
                 using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                 {
                     var fileContent = reader.ReadToEnd();
                     Console.WriteLine(fileContent);

                 }
             }

         }*/

       /*public async Task Main(string[] args)
        {
            var owner = string.Empty;
            var reponame = string.Empty;

            owner = "nlturner2";
            reponame = "CS690-Project";

            var client = new GitHubClient(new Octokit.ProductHeaderValue("nlturner2"));

            var repository = await client.Repository.Get(owner, reponame);

            Console.WriteLine(String.Format("Octokit.net can be found at {0}\n", repository.HtmlUrl));

            Console.WriteLine("It currently has {0} watchers and {1} forks\n",
                repository.StargazersCount,
                repository.ForksCount);

            //Console.WriteLine("It has {0} open issues\n", repository.OpenIssuesCount);

            //Console.WriteLine("And GitHub thinks it is a {0} project", repository.Language);

        }*/

        /* public async Task<String> GetData()
         {
             var client = new GitHubClient(new Octokit.ProductHeaderValue("nlturner2/CS690-Project"));
             var tokenAuth = new Credentials("token"); // NOTE: not real token
             client.Credentials = tokenAuth;
             var user = await client.User.Get("nlturner2");
             Console.WriteLine("{0} has {1} public repositories - go check out their profile at {2}",
                 user.Name,
                 user.PublicRepos,
                 user.Url);
         }
         */

    }

}


