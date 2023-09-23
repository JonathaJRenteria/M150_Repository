using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    private int birthdayMonth = 10;
    private int birthdayDay = 28;

    private void Start()
    {
        for (int month = 1; month <= 12; month++)
        {
            if (month == birthdayMonth)
            {
                Debug.Log("It's my Birthday!");

                for (int day = 1; day <= 31; day++) 
                { 

                if (day == birthdayDay)
                    {
                    Debug.Log("It's my birthday!");
                }
                else
                {
                    Debug.Log(day);
                }
            }
        }
        else
        {
            Debug.Log(month);
            }
        }
        
    }
}
