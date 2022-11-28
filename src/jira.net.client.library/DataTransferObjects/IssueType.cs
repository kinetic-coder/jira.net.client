namespace jira.net.client.library.DataTransferObjects;

public class IssueType {
    public string name { get; set; }

    public IssueType() => this.name = "";

    public override string ToString()
    {
        return name;
    }
}