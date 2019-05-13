using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackInOpt : MonoBehaviour
{
    public void StopRainig()
    {
        var clones = GameObject.FindGameObjectsWithTag("Drip");
        foreach (var clone in clones)
        {
            Destroy(clone);
        }
    }
}
