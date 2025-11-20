/*
 * Roofing Inspection Input System
 * 
 * This program allows a roofing contractor to input inspection data for multiple roofs
 * and generates an analysis report to identify potential issues and maintenance needs.
 * 
 * Program Flow:
 * 1. Ask user how many roofs they want to inspect
 * 2. For each roof, collect four pieces of data:
 *    - Area in square feet (size of the roof)
 *    - Pitch in degrees (steepness of the roof)
 *    - Age in years (how old the roof is)
 *    - Material type (what the roof is made of)
 * 3. Analyze all roof data using loops to calculate:
 *    - Total number of roofs inspected
 *    - Average age across all roofs
 *    - Roofs needing replacement (age > 20 years)
 *    - Dangerous roofs (pitch > 30 degrees - safety concern for workers)
 *    - Large roofs (area > 2000 sq ft - complex projects)
 *    - Critical roofs (both old AND steep - high risk combination)
 * 4. Display a comprehensive inspection report
 * 
 * Real-world roofing context:
 * - Replacement threshold: > 20 years (typical roof lifespan)
 * - Dangerous pitch: > 30 degrees (requires special safety equipment)
 * - Large roof: > 2000 sq ft (more complex, time-consuming projects)
 * - Critical: Old AND steep (high risk of failure and dangerous to repair)
 * - Common materials: Asphalt, Metal, Tile, Wood, Slate, etc.
 * 
 * Sample Input Sequence:
 * - User enters number of roofs (e.g., 3)
 * - For each roof, user enters area, pitch, age, and material
 * - Program processes all data and shows analysis
 * 
 * The program will use:
 * - Arrays to store multiple roof measurements
 * - Loops for data collection and analysis
 * - Conditional statements to classify roof conditions
 * - Mathematical operations for averages and totals
 * - String handling for material types
 */

using System.Formats.Asn1;

using System;

Console.Write("How many roofs to inspect? ");
int numberOfRoofs = Convert.ToInt32(Console.ReadLine());

int[] ageRoof = new int[numberOfRoofs];
int[] areaSQFT = new int[numberOfRoofs];
int[] pitchDegrees = new int[numberOfRoofs];
string[] materialType = new string[numberOfRoofs];

for (int i = 0; i < numberOfRoofs; i++)
{
    Console.Write($"Enter the age of roof {i + 1}: ");
    ageRoof[i] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter area (sq ft): ");
    areaSQFT[i] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Pitch (degrees): ");
    pitchDegrees[i] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter material: ");
    materialType[i] = Console.ReadLine();
}

int totalAge = 0;
int needReplacement = 0;
int dangerousPitch = 0;
int largeRoofs = 0;
int criticalRoofs = 0;

for (int i = 0; i < numberOfRoofs; i++)
{
    totalAge += ageRoof[i];

    if (ageRoof[i] > 20)
        needReplacement++;   
    if (pitchDegrees[i] > 30)
        dangerousPitch++;     
    if (areaSQFT[i] > 2000)
        largeRoofs++;        

    if (ageRoof[i] > 20 && pitchDegrees[i] > 30)
        criticalRoofs++;      
}

int averageAge = numberOfRoofs > 0 ? totalAge / numberOfRoofs : 0;

Console.WriteLine($"\nAverage Roof Age: {averageAge}");
Console.WriteLine($"Roofs needing replacement: {needReplacement}");
Console.WriteLine($"Roofs with dangerous pitch: {dangerousPitch}");
Console.WriteLine($"Large roofs : {largeRoofs}");
Console.WriteLine($"CRITICAL roofs : {criticalRoofs}");






