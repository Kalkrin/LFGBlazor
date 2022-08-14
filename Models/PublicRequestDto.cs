﻿namespace LFGWebApp
{ 
    public class PublicRequestDto
    {
    public int Id { get; set; }
    public PublicUserDto Requestor { get; set; }
    public PublicGameDto Game { get; set; }
    public Status Status { get; set; }
    public string? Message { get; set; }
    public DateTime Created { get; set; }
    public DateTime LastEdited { get; set; }
    }
    public enum Status
    {
        Approved = 1,
        Declined = 2,
        Undecided = 3
    }
}
