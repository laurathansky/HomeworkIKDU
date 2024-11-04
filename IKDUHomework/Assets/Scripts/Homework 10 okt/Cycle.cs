using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cycle
{
    public Woman Woman { get; set; }
    public int DayOfCycle { get; set; }
    public bool Bleeding { get; set; }
    public string DominantHormone { get; set; }

    public Cycle(Woman woman, int dayOfCycle)
    {
        this.Woman = woman;
        this.DayOfCycle = dayOfCycle;

        // Set properties based on DayOfCycle
        this.Bleeding = DetermineBleeding(dayOfCycle);
        this.DominantHormone = DetermineDominantHormone(dayOfCycle);
    }


     // Method to determine if the woman is bleeding based on the day of the cycle
    private bool DetermineBleeding(int dayOfCycle)
    {
        // Example: Assume days 23-28 are bleeding days
        return dayOfCycle >= 23 && dayOfCycle <= 28;
    }

     // Method to determine the dominant hormone based on the day of the cycle
    private string DetermineDominantHormone(int dayOfCycle)
    {
        if (dayOfCycle >= 1 && dayOfCycle <= 5)
            return "Estrogen"; // Menstrual phase
        else if (dayOfCycle >= 6 && dayOfCycle <= 14)
            return "Estrogen"; // Follicular phase
        else if (dayOfCycle >= 15 && dayOfCycle <= 21)
            return "Progesterone"; // Luteal phase
        else if (dayOfCycle >= 22 && dayOfCycle <= 28)
            return "Progesterone"; // Late luteal phase
        else
            return "Unknown"; // Out of range or unknown cycle phase
    }


    // Method to print cycle information
    public void PrintCycleInfo()
    {
        UnityEngine.Debug.Log($"Name: {Woman.Name}");
        UnityEngine.Debug.Log($"Day of Cycle: {DayOfCycle}");
        UnityEngine.Debug.Log($"Bleeding: {(Bleeding ? "Yes" : "No")}");
        UnityEngine.Debug.Log($"Dominant Hormone: {DominantHormone}");
    }

}
