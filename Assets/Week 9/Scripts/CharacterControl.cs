using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterControl : MonoBehaviour
{
    public TextMeshProUGUI typeText;

    public static CharacterControl instance;

    private void Start()
    {
        instance = this;
        instance.typeText.GetComponent<TextMeshProUGUI>().text = "None Selected";
    }

    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        instance.typeText.GetComponent<TextMeshProUGUI>().text = villager.ToString();
            
    }
    
}
