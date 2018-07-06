using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SoftwareManagement : MonoBehaviour {

private DataBaseInteraction m_DataBase = new DataBaseInteraction();
    private static int  ID, TABLENUMBER,TOTAL,PRICE,AMOUNT;
    private static string PAYMENTMETHODE, PASSWORD, NAME;
    private static DateTime DATE;
    private static bool BOOKED;


    public bool LoadTableData(string TableNumber, string Booked)
    {
        string[] _TableNumber = m_DataBase.GetAttributeOfAllTables("TableNumber").Split('\t');
        string[] _Booked = m_DataBase.GetAttributeOfAllTables("Booked").Split('\t');



        if (_TableNumber == null )
            return false;

        foreach (string s in _TableNumber)
        {
            Debug.Log(s);
        }
      

        Debug.Log("Names.Length: " + names.Length);
        Debug.Log("Passwords.Length: " + passwords.Length);
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i].Equals(Name))
            {
                USERNAME = Name;
                USER_ID = i + 1;
                PASSWORD = passwords[i];

                Debug.Log("UserName: " + USERNAME + " | Password: " + PASSWORD);
            }
        }

        Debug.Log(USER_ID);

        if (Password.Equals(PASSWORD))
        {
            string[] userData = m_DataBase.GetUserData(USER_ID).Split('\t');

            foreach (string s in userData)
            {
                Debug.Log("UserData: " + s);
            }
            MONEY = System.Int32.Parse(userData[3]);
            LEVEL_PROGRESS = System.Int32.Parse(userData[4]);
            HEARTS = System.Int32.Parse(userData[5]);
            BOMBS = System.Int32.Parse(userData[6]);
            SHIELDS = System.Int32.Parse(userData[7]);
            POTIONS = System.Int32.Parse(userData[8]);

            Debug.Log("Password correct");
        }
        else
        {
            Debug.Log("Password incorrect");
            return false;
        }

        return true;

    }


}
