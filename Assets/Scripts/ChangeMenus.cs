using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMenus : MonoBehaviour
{
    public GameObject Menu1;
    public GameObject Menu2;


    public void Change()
    {
        Menu1.SetActive(false);
        Menu2.SetActive(true);
    }
}
