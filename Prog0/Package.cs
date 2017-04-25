// Program 1A
// CIS 200-01
// Fall 2016
// Due: 10/11/2016
// Grading ID: C9664

// File: Package.cs
// A class that determines the size and dimensions of a package

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Package : Parcel
{
    // Precondition:  None
    // PostCondition: The package is created with the specified values for the origin address,
    //                destination address and the packages dimensions
    public Package(Address originAddress, Address destAddress, double length,
        double width, double height, double weight) : base (originAddress, destAddress)
    {

        Length = length;
        Width = width;
        Height = height;
        Weight = weight;

    }

    // Auto implementation of property Length
    public double Length { get; set; }
    
    // Auto implementation of property Width
    public double Width { get; set; }

    // Auto implementation of property Height
    public double Height { get; set; }

    // Auto implementation of property Weight
    public double Weight { get; set; }
    
    // Precondition:  None
    // Postcondition: A string with the packages data has been return
    public override string ToString()
    {
        return String.Format("Origin Address: {6}{0}{6}{6}Destination Address: {6}{1}{6}{6}Length: {2}{6}Width: {3}{6}Height: {4}{6}Weight: {5}{6}",
            OriginAddress, DestinationAddress, Length, Width, Height, Weight, Environment.NewLine);
    }

}

