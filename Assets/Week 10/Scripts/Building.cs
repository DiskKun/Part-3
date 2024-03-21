using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public GameObject layer1;
    public GameObject layer2;
    public GameObject layer3;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 v = new Vector3(0, 0, 1);
        layer1.transform.localScale = v;
        layer2.transform.localScale = v;
        layer3.transform.localScale = v;
        

        StartCoroutine(AllLayers());
    }
    IEnumerator AllLayers()
    {
        yield return StartCoroutine(Layer1());
        yield return StartCoroutine(Layer2());
        yield return StartCoroutine(Layer3());
    }

    IEnumerator Layer1()
    {
        float timer = 0;
        while (layer1.transform.localScale.x < 1)
        {
            timer += Time.deltaTime;
            layer1.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timer / 0.3f);
            yield return null;
        }
    }

    IEnumerator Layer2()
    {
        float timer = 0;
        while (layer2.transform.localScale.x < 1)
        {
            timer += Time.deltaTime;
            layer2.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timer / 0.3f);
            yield return null;
        }
    }

    IEnumerator Layer3()
    {
        float timer = 0;
        while (layer3.transform.localScale.x < 1)
        {
            timer += Time.deltaTime;
            layer3.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timer / 0.3f);
            yield return null;
        }
    }

}
