using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAbil : MonoBehaviour
{
    private Player player;

    private Delay ability;
    private Delay colldown;
    private bool canAbil = true;
    private bool isColl = false;

    public SpriteRenderer Abilsr;

    void Start()
    {
        player = GetComponent<Player>();
        ability.lastTime = 2f;
        ability.curTime = 0f;

        colldown.lastTime = 5f;
        colldown.curTime = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && canAbil)
        {
            player.speed *= 1.5f;
            canAbil = false;
            Abilsr.gameObject.SetActive(false);
        }

        if(!isColl)
            Ability();

        CollDown();
    }

    private void Ability()
    {
        if(ability.curTime > ability.lastTime)
        {
            ability.curTime = 0f;
            player.speed /= 1.5f;
            isColl = true;
        }
        else if(!canAbil)
        {
            ability.curTime += Time.deltaTime;
        }
    }

    private void CollDown()
    {
        if(colldown.curTime > colldown.lastTime)
        {
            Abilsr.gameObject.SetActive(true);
            colldown.curTime = 0f;
            isColl = false;
            canAbil = true;

        }
        else if(isColl)
        {
            colldown.curTime += Time.deltaTime;
        }
    }
}
