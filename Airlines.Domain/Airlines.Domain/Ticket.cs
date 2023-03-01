﻿namespace Airlines.Domain;

/// <summary>
/// Class describing a ticket
/// </summary>
public class TicketClass
{
    /// <summary>
    /// Represent a unique ID of ticket
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Represent a number of ticket
    /// </summary>
    public int TicketNumber { get; set; }
    /// <summary>
    /// Represent a seatnumber of ticket
    /// </summary>
    public string SeatNumber { get; set; }
    /// <summary>
    /// Represent a baggage weight, which passanger can move
    /// </summary>
    public int BaggageWeight { get; set;}
    public TicketClass() {}
    public TicketClass(int ticketNumber, string seatNumber, int baggageWeight)
    {
        TicketNumber = ticketNumber;
        SeatNumber = seatNumber;
        BaggageWeight = baggageWeight;
    }
}
