// Program 1A
// CIS 200-01
// Fall 2016
// Due: 10/11/2016
// Grading ID: C9664

// File: TwoDayAirPackage.cs
// a derived class from AirPackage that determines the type of delivery and calculates
// the discount based on what type of delivery is chosen

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TwoDayAirPackage : AirPackage
{
    private const decimal SAVER_DISCOUNT = .9M; // constant variable that holds the discount
    private decimal baseCost;                   // Variable that holds the calculated cost

    public enum Delivery { Early, Saver };      // Delivery type enum that defines two choices

    // Precondition:  None
    // Postcondition: The TwoDayAirPackage is created with the specified values for the origin address,
    //                destination address, dimensions, and delivery type
    public TwoDayAirPackage(Address originAddress, Address destAddress, double lenght, double width, double height, double weight, Delivery type) :
        base (originAddress, destAddress, lenght, width, weight, weight)
    {
        DeliveryType = type;
    }

    // Auto implementation of property delivery using enum Delivery
    public Delivery DeliveryType { get; set; }

    // Precondition:  None
    // Postcondition: The TwoDayAirPackage cost is returned
    public override decimal CalcCost()
    {
        baseCost = .25M * Convert.ToDecimal((Length + Width + Height)) + .25M * Convert.ToDecimal(Weight);

        if (DeliveryType == Delivery.Saver)
        {
            return baseCost * SAVER_DISCOUNT;
        }
        else
            return baseCost;
    }

    // Precondition: None
    // Postcondition: A string with the TwoDayAirPackage data is returned
    public override string ToString()
    {
        return String.Format("Origin Address: {8}{0}{8}{8}Destination Address: {8}{1}{8}{8}Length: {2}{8}Width: {3}{8}Height: {4}{8}Weight: {5}{8}Delivery Type: {6}{8}", 
            OriginAddress, DestinationAddress, Length, Width, Height, Weight, DeliveryType, Environment.NewLine);
    }

}

