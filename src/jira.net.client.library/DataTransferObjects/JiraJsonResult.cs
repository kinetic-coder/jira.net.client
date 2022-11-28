namespace jira.net.client.library.DataTransferObjects;

public class JiraResponse {
    public int maxResults { get; set; }
    public int total { get; set; }
    public Issue[]? issues { get; set; }
}