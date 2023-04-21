﻿namespace Airlines.Domain;

/// <summary>
/// Сlass describing the passenger
/// </summary>
public class Passenger
{
    /// <summary>
    /// Represent a unique Id of passanger
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Represent a passport number 
    /// </summary>
    public string? PassportNumber { get; set; }
    /// <summary>
    /// Represent a passenger name
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Represent a tickets 
    /// </summary>
    public List<Ticket> Tickets { get; set; } = new List<Ticket>();
    public Passenger() { }
    public Passenger(string passportNumber, string name)
    {
        PassportNumber = passportNumber;
        Name = name;
    }
}