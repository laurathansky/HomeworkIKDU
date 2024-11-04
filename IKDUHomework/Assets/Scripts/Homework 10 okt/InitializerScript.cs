using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Initializer : MonoBehaviour
{
    void Start()
    {
        Woman woman = new Woman("Alice");
        Cycle cycle = new Cycle(woman, 3); 
        cycle.PrintCycleInfo();

        Woman woman1 = new Woman("Laura");
        Cycle cycle1 = new Cycle(woman1, 22);
        cycle1.PrintCycleInfo();

        Woman woman2 = new Woman("James Bond is on his period");
        Cycle cycle2 = new Cycle(woman2, 28);
        cycle2.PrintCycleInfo();

        Woman woman3 = new Woman("Mom");
        Cycle cycle3 = new Cycle(woman3, 28);
        cycle3.PrintCycleInfo();


    }
}
