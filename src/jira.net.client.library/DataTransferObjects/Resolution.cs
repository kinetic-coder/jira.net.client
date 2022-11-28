namespace jira.net.client.library.DataTransferObjects;

public class Resolution {
    public string name { get; set; }

    public Resolution() => this.name = "";

    public override string ToString()
    {
        return name;
    }
}