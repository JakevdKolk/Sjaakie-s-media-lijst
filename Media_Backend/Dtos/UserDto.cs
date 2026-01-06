namespace Media_Backend.Dtos
{
   public record UserDto
   (
       int Id,
       string Username,
       string Email
   );

    public record CreateUserDto(
       string Username,
       string Email,
       string Password
        
     );
}
