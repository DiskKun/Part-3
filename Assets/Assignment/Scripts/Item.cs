using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    public int price;
    public static int money;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI itemText;

    protected virtual void Start()
    {
        ChangeMoney(25);
    }

    public static void ChangeMoney(int a)
    {
        money += a;
    }

    private void Update()
    {
        moneyText.text = "Money: $" + money;
    }

    public virtual void OnMouseEnter()
    {
        StartCoroutine(HoverAnimation());
    }

  
    private void OnMouseExit()
    {
        StopAllCoroutines();
        StartCoroutine(Shrink());
        itemText.text = "";
    }

    private void OnMouseDown()
    {
        if (money >= price)
        {
            ChangeMoney(-price);
        } else
        {
            itemText.text = "You can't afford that!";
        }
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
