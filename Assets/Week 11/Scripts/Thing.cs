using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thing : MonoBehaviour
{
    public static float staticNumber;
    public float notStaticNumber;
    // Start is called before the first frame update
    void Start()
    {
        staticNumber = Random.Range(0, 10);
        notStaticNumber = Random.Range(0, 10);


    }
}
