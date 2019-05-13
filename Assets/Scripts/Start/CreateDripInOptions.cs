using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDripInOptions : MonoBehaviour
{
    public GameObject drip;
    private bool tostart;
    private IEnumerator coDrip;

    void Start()
    {
        coDrip = spawndrip();
    }

    public void MakeRain()
    {
        tostart = true;
    } 

    IEnumerator spawndrip()
    {
        while (true)
        {
            Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(Screen.height - 1, Screen.height), Camera.main.farClipPlane / 2));
            GameObject Drip = Instantiate(drip, screenPosition, Quaternion.identity);
            Drip.gameObject.tag = "Drip";

            yield return new WaitForSeconds(0.001f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(tostart)
        {
            StartCoroutine(coDrip);
            tostart = false;
        }
    }
}
