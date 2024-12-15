namespace Store.Api.DTOs;

public record UserDto(
    string FirstName,
    string LastName,
    string PhoneNumber,
    string Email,
    string Password);
