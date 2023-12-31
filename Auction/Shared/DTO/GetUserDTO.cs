﻿namespace Shared.DTO;

public class GetUserDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public decimal WalletBalance { get; set; }
    public DateTime DateCreated { get; set; }
}