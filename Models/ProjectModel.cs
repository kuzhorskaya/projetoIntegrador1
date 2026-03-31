public class Project
{
    public int Id {get; set;}
    public required string Name {get; set;}
    public required string Description {get; set;}
    public required string Teacher {get; set;}
    public DateTime CreationDate {get; set;}
    public List<User> UserList = new List<User>(); 
}