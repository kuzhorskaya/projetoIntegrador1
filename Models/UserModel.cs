public class User
{
    public int Id {get; set; }
    public required string Name {get; set; }
    public required string Password {get; set; }
    public required string Email {get; set; }
    public List<Project> ProjectList = new List<Project>();  


    // TODO: Este é o modelo de usuário. Quando estiver confortável, adicione:
    // - Validations: [Required], [EmailAddress], [MinLength(6)] etc.
    // - Relacionamento de navegação para projetos (ICollection<Projeto> Projects).
    // - Crie Models/ProjectModel.cs com Id, Name, Description, Teacher, UserId.
    // Docs: https://learn.microsoft.com/aspnet/core/mvc/models/validation
    // Docs: https://learn.microsoft.com/ef/core/modeling/relationships
}