using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform spawnPoint;
    protected override void Attack()
    {
        base.Attack();
        Instantiate(daggerPrefab, spawnPoint.position, spawnPoint.rotation);
        Instantiate(daggerPrefab, spawnPoint.position + new Vector3(1, 0, 0), spawnPoint.rotation);
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
}
