// Program 1A
// CIS 200-01
// Fall 2016
// Due: 10/11/2016
// Grading ID: C9664

// File: NextDayAirPackage.cs
// A derived class from AirPackage that calculates the cost based on the weight
// and size of the package and includes the express fee as well

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NextDayAirPackage : AirPackage
{
    private const decimal HEAVY_RATE = .25M;    // Constant variable that contains the heavy rate
    private const decimal LARGE_RATE = .25M;    // Constant Variable that contains the large rate
    private decimal weightCharge = 0;           // WeightCharge variable that is set at zero
    private decimal largeCharge = 0;            // LargeCharge variable that is set at zero
    private decimal baseCost;                   // variable that holds the base cost

    // Precondition:  None
    // Postcondition: The NextDayAirPackage is created with the specified values for the origin address,
    //                destination address, dimensions, and express fee
    public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight, decimal expressFee) :
        base(originAddress, destAddress, length, width, weight, weight)
    {
        ExpressFee = expressFee;
    }

    // Precondition:  None
    // Postcondition: Auto implementation of property ExpressFee with only a get
    public decimal ExpressFee { get;  }

    // Precondition:  None
    // Postcondition: The NextDayAirPackage cost is returned
    public override decimal CalcCost()
    {

        baseCost = .4M * Convert.ToDecimal(Length + Width + Height) + .3M * Convert.ToDecimal(Weight) + ExpressFee;

        if (IsHeavy() == true)
        {
            weightCharge = HEAVY_RATE * Convert.ToDecimal(Weight);
        }

        if (IsLarge() == true)
        {
            largeCharge = LARGE_RATE * Convert.ToDecimal((Length + Width + Height));
        }

        return baseCost + weightCharge + largeCharge;

    }

    // Precondition:  None
    // Postcondition: A string with the NextDayAirPackages data is returned
    public override string ToString()
    {
        return String.Format("Origin Address: {7}{0}{7}{7}Destination Address: {7}{1}{7}{7}Length: {2}{7}Width: {3}{7}Height: {4}{7}Weight: {5}{7}Express Fee: {6:C}{7}", 
            OriginAddress, DestinationAddress, Length, Width, Height, Weight, ExpressFee, Environment.NewLine);
    }
}
