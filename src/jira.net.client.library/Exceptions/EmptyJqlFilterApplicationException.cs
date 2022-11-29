namespace jira.net.client.library.Exceptions;

public class EmptyJqlFilterException : Exception {
    public EmptyJqlFilterException(string message): base(message){
        
    }
}