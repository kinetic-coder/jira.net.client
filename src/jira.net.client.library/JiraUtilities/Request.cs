namespace jira.net.client.library.JiraUtilities;

using jira.net.client.library.Exceptions;
using RestSharp;
using System.Text;

public class Request
{
    private string _personalAccessToken = "";
    private string _companyJiraDomain = "";

    private const string SEARCH = @"/search?jql=";
    private string GetCompanyJiraUrl()
    {
        return @$"https://{_companyJiraDomain}/rest/api/2";
    }

    public Request(string personalAccessToken, string companyJiraDomain)
    {
        _personalAccessToken = personalAccessToken;
        _companyJiraDomain = companyJiraDomain;
    }

    public string Search(string jqlfilter)
    {

        if (jqlfilter == string.Empty)
            throw new EmptyJqlFilterException("No JQL filter has been provided");

        string result = String.Empty;

        StringBuilder url = new StringBuilder(500);

        // build the url
        url.Append(GetCompanyJiraUrl());
        url.Append(SEARCH);
        url.Append(jqlfilter);

        // make the call to Jira.
        try
        {
            var client = new RestClient(url.ToString());
            var request = new RestRequest
            {
                Method = Method.Get,
                RequestFormat = DataFormat.Json
            };

            request.AddHeader("Authorization", "Bearer " + _personalAccessToken);
            var response = client.Execute(request);
            result = response.Content;
        }
        catch (Exception ex)
        {
            result = "";
        }
        return result;
    }
}