namespace Core.Entities;
public class UserRoles{
    public int RoleId { get; set; }
    public Role? Role { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }
}