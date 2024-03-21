using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform spawnPoint;
    Coroutine dashing;
    protected override void Attack()
    {
        if (dashing != null)
        {
            StopCoroutine(dashing);            
        }
        dashing = StartCoroutine(Dash());
    }

    IEnumerator Dash()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = 7;
        while (speed > 3)
        {
            yield return null;
        }
        base.Attack();
        yield return new WaitForSeconds(0.1f);
        Instantiate(daggerPrefab, spawnPoint.position, spawnPoint.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(daggerPrefab, spawnPoint.position + new Vector3(1, 0, 0) * transform.localScale.x, spawnPoint.rotation);

    }



    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    public override string ToString()
    {
        return "It's thieving time.";
    }
}
