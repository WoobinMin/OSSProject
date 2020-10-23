using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimScr : MonoBehaviour
{
    private SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        switch(CharacterMgr.Instance.Charcolor)
        {
            case 0:
                sr.color = new Color(255, 255, 255);
                break;
            case 1:
                sr.color = new Color(255, 255, 0    );
                break;
            case 2:
                sr.color = new Color(211, 0, 255);
                break;
        }
    }
}
