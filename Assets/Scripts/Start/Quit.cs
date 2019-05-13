using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void exit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}
