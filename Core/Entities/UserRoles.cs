namespace Core.Entities;
public class UserRoles{
    public int RoleId { get; set; }
    public Role? Role { get; set; }

    public string UserId { get; set; } = null!;
    public User? User { get; set; }
}