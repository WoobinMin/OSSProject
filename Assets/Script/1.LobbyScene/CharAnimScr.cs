using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimScr : MonoBehaviour
{
    private SpriteRenderer sr;

    public Sprite boysr;
    public Sprite catsr;
    public Sprite dogsr;


    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        switch(CharacterMgr.Instance.Charselect)
        {
            case 0:
                sr.sprite = boysr;
                break;
            case 1:
                sr.sprite = catsr;
                break;
            case 2:
                sr.sprite = dogsr;
                break;
        }
    }
}
