using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// make ur weekly schedule (1) using swith statement/case (2) without using case 
//Made in in collaboration with Valdemar 

public class WeeklyScheduleHomework : MonoBehaviour
{

    // Declaring and the varible - in this variable i can declare what day of the week i want the code to run to
    public string WeekDay = "friday";

    // Start is called before the first frame update
    void Start()
    {
        //calling the switch method
        MySchedule();

        //calling the if statement function
        MyIfSchedule();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MySchedule()
    {
        switch(WeekDay)
        {
            case "monday":
             Debug.Log("Pilates in the morning and then p1");
            break;
            case "tuesday":
             Debug.Log("p1 group work and chill with friends");
            break;
             case "wednesday":
             Debug.Log("PBL and homework");
            break;
            case "thursday":
             Debug.Log("IKDU with olga");
            break;
            case "friday":
             Debug.Log("Party!");
            break;
            case "Saturday":
             Debug.Log("Pilates if i am not hungover");
            break;
            case "Sunday":
             Debug.Log("Rest and chill and get ready for the week");
            break;

        }

    }

    public void MyIfSchedule()
    {
        if(WeekDay == "monday")
        {
            Debug.Log(" funday");
        }
        else if(WeekDay == "tuesday")
        {
            Debug.Log("tuesday i rest");
        }
        else if(WeekDay == "wednesday")
        {
            Debug.Log("how do you even spell wedensday :D");
        }
        else if(WeekDay == "thursday")
        {
            Debug.Log("IKDU with olga is great on thursday");
        }
        else if(WeekDay == "friday")
        {
            Debug.Log("friday for slay");
        }
        else if(WeekDay == "saturday")
        {
            Debug.Log("saturday i rest and do olga homework");
        }
        else if(WeekDay == "sunday")
        {
            Debug.Log("sunday i also rest cus IKDU is stressfull ... :D");
        }
        else // no condition
        {
            Debug.Log("you need to define a day of the week girl!");
        }
    
        

    }

}
