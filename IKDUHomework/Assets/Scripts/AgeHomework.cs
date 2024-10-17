using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Homework: (1) Make a method/function that returns age next year (2) make method that returns age after n years (3) confirming debug.log 

public class AgeHomework : MonoBehaviour
{
    //defining the variables
    public int currentAge = 23; 
    public int n = 7;

    // Start is called before the first frame update
    void Start()
    {
        //calling the +1 year function
        int newAge = computeAge(currentAge);
        Debug.LogFormat("{0}", newAge); //output

        //calling the + n years function
        int ageInNYears = computeAge(currentAge, n);
        Debug.LogFormat("{0}", ageInNYears); //output

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    ///<summary>
    ///method that returns + 1 to currentAge
    ///<summary>
    int computeAge(int myAge)
    {
        return (myAge+1);
    }

    ///<summary>
    ///method that returns + n to currentAge
    ///<summary> 
    int computeAge(int myAge, int addedAge)
    {
        return (myAge + addedAge);
    }
}
