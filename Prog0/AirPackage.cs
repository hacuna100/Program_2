// Program 1A
// CIS 200-01
// Fall 2016
// Due: 10/11/2016
// Grading ID: C9664

// File: AirPackage.cs
// A derived class from Package that determines whether or not
// the package is over weight and/or over sized

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class AirPackage : Package
{
    private const int isHeavy = 75;     // Constant variable that contains the minimum weight
    private const int isLarge = 100;    // Constant variable that contains the minimum dimension

    // Precondition:  None
    // Postcondition: The AirPackage is created with the specified values for the origin address,
    //                destination address and the packages dimensions without initializing new data
    public AirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight) :
        base (originAddress, destAddress, length, width, weight, weight)
    {

    }

    // Precondition:  The weight is a valid double
    // Postcondition: Sets true or false based on the minimum weight requirement
    public bool IsHeavy()
    {
      if (Weight >= isHeavy)
        {
            return true;
        }
      else
            return false;
    }

    // Precondition:  The dimension's are a valid doubles
    // Postcondition: Sets true or false based on the minimum weight requirement
    public bool IsLarge()
    {
        if ((Length+Width+Height) >= isLarge)
        {
            return true;
        }
        else
            return false;
    }

    // Precondition:  None
    // Postcondition: A string with the Airpackage's data has been return
    public override string ToString()
    {
        return String.Format("Origin Address: {8}{0}{8}{8}Destination Address: {8}{1}{8}{8}Length: {2}{8}Width: {3}{8}Height: {4}{8}Weight: {5}{8}Overweight: {6}{8}Oversized: {7:C}{8}",
            OriginAddress, DestinationAddress, Length, Width, Height, Weight, IsHeavy(), IsLarge(), Environment.NewLine);
    }

}