using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPause : MonoBehaviour
{
    public GameObject PauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!PauseMenu.active)
            {
                PauseMenu.SetActive(true);
                Time.timeScale = 0;
            }
            else 
            {
                PauseMenu.SetActive(false);
                Time.timeScale = 1f;    
            }
        }

    }
}
