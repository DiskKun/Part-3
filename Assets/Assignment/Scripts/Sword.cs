using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Item
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        price = 40;
    }


    public override void OnMouseEnter()
    {
        base.OnMouseEnter();
        itemText.text = "This is a sword! Its price is $" + price + ".";

    }
}
