namespace jira.net.client.library.JiraUtilities;

public class Request {
    private string _personalAccessToken = "";

    public Request(string personalAccessToken) {
        _personalAccessToken = personalAccessToken;
    }
}