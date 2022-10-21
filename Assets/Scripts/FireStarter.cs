using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStarter : MonoBehaviour
{
    public static float casilla = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static float Firedet()
    {
        casilla = Random.Range(0, 10);
        return casilla;
    }
}
