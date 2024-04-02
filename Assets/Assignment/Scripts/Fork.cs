using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fork : Item
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        price = 10;
    }

    public override void OnMouseEnter()
    {
        base.OnMouseEnter();
        itemText.text = "This is a fork! Its price is $" + price + ".";
       
    }
}
