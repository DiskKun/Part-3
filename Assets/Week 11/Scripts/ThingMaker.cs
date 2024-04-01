using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingMaker : MonoBehaviour
{
    public GameObject thingPrefab;
    public float whatIsTheStaticNumber;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(thingPrefab);
        }
    }
}
