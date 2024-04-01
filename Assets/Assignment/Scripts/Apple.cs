using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Item
{
    private void Start()
    {
        price = 5;
    }

    public override void OnMouseEnter()
    {
        base.OnMouseEnter();
        itemText.text = "This is an apple! Its price is $" + price + ".";
    }
}
