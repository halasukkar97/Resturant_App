using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager : MonoBehaviour {

    public static string password = "0000";
    public InputField passcod;
    public Text incorrect;

    // Use this for initialization
    public void Check ()
    {
        if(passcod.text==password)
        {
            
            SceneManager.LoadScene(1);
            passcod.text = "";
        }
        else
        {
            incorrect.text = "Wrong code please try one more time";
            passcod.text = "";
        }
		
	}

  

    public void Waiter()
    {
        SceneManager.LoadScene(2);
    }

    public void Backfrommanager()
    {
        incorrect.text = "";
        passcod.text = "";
    }
}
