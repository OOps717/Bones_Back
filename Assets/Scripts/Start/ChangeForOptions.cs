using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeForOptions : MonoBehaviour
{
    public GameObject Menu1;
    public GameObject Menu2;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Menu2.SetActive(false);
            Menu1.SetActive(true);
            var clones = GameObject.FindGameObjectsWithTag("Drip");
            foreach (var clone in clones)
            {
                Destroy(clone);
            }
        }
    }
}
