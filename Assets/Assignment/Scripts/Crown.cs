using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crown : Item
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        price = 50;
    }

    public override void OnMouseEnter()
    {
        base.OnMouseEnter();
        itemText.text = "This is a crown! Its price is $" + price + ".";

    }
}
