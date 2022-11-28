namespace jira.net.client.library.DataTransferObjects;

public class JiraUser {
    public string name { get; set; }
    public string emailAddress {get; set;}

    public JiraUser() {
        name = "";
        emailAddress = "";
    }

    public override string ToString()
    {
        return $"{name} - {emailAddress}";
    }
}