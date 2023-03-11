using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void Exit_app()
    {
        Application.Quit();
        Debug.Log("Application has been quit");
    }
}
