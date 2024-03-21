using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDemo : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public SpriteRenderer sr;
    public Color start;
    public Color end;
    float interpolation;
    public void SliderHasChangedValue(Single value)
    {
        interpolation = value / 60;
    }
    private void Update()
    {

        sr.color = Color.Lerp(start, end, interpolation);
    }
    public void DropdownHasChangedValue(Int32 value)
    {
        Debug.Log(dropdown.options[value].text);
    }
}
