using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    public TextMeshProUGUI itemText;
    public float price;

    public virtual void OnMouseEnter()
    {
        StartCoroutine(HoverAnimation());
    }

    private void OnMouseExit()
    {
        StopAllCoroutines();
        StartCoroutine(Shrink());
    }

    

    IEnumerator HoverAnimation()
    {
        while (transform.localScale.x < 1.5)
        {
            transform.localScale = transform.localScale * 1.02f;
            yield return null;
        }
    }

    IEnumerator Shrink()
    {
        while (transform.localScale.x > 1)
        {
            transform.localScale = transform.localScale * 0.9f;
            yield return null;
        }
    }
}
