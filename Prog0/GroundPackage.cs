// Program 1A
// CIS 200-01
// Fall 2016
// Due: 10/11/2016
// Grading ID: C9664

// File: GroundPackage.cs
// A derived class from the Package class and calculates the zip code distance
// that the package is transported

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GroundPackage : Package
{
    private decimal cost; // variable that holds the calculated shipping cost


    // Precondition:  None
    // Postcondition: GroundPackage constructor that contains all the base class values
    //                and doesn't initialize any new data
    public GroundPackage(Address originAddress, Address destAddress, double length,
        double width, double height, double weight) : base(originAddress, destAddress,
            length, width, height, weight)
    {

    }

    // Precondition:  Addresses contain valid zip codes
    // PostCondition: A method that calculates the distance between zip codes
    public int ZoneDist
    {
        // Precondition:  None
        // PostCondition: The calcuated distance between the zip codes is returned
        get
        {
            const int FIRST_DIGIT_FACTOR = 10000; // Denominator to extract the 1st digit
            int dist;                             // holds the calculated zip code distance

            dist = Math.Abs((OriginAddress.Zip / FIRST_DIGIT_FACTOR) - (DestinationAddress.Zip / FIRST_DIGIT_FACTOR));

            return dist;
        }
    }

    // Precondition:  None
    // Postcondition: The GroundPackage cost is returned
    public override decimal CalcCost()
    {
        cost = .20M * Convert.ToDecimal((Length + Width + Height)) + .05M * Convert.ToDecimal((ZoneDist + 1)) * Convert.ToDecimal(Weight);

        return cost;
    }

    // Precondition:  None
    // Postcondition: A string with the GroundPackage data has been returned
    public override string ToString()
    {
        return String.Format("Origin Address: {8}{0}{8}{8}Destination Address: {8}{1}{8}{8}Length: {2}{8}Width: {3}{8}Height: {4}{8}Weight: {5}{8}Zone Distance: {6}{8}Cost: {7:C}{8}",
          OriginAddress, DestinationAddress, Length, Width, Height, Weight, ZoneDist, CalcCost(), Environment.NewLine);
    }
}
