﻿namespace UserService.Application.Dtos;

public class ProjeliUserDto
{
    public string Id { get; set; }
    
    public string UserName { get; set; }
    
    public string? FirstName { get; set; }
    
    public string? LastName { get; set; }
    
    public string? Email { get; set; }
    
    public string? ImageUrl { get; set; }
}