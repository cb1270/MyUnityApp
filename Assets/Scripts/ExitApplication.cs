using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApplication : MonoBehaviour
{

    public void ExitTheApp()
    {
        Application.Quit();
        Debug.Log("Application is exiting");
        //to test it is working when running in unity
    }

}

