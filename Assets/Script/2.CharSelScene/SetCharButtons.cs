using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetCharButtons : MonoBehaviour
{
    public bool isSelect;

    public SetCharButtons button1;
    public SetCharButtons button2;

    public SpriteRenderer sr1;
    public SpriteRenderer sr2;
    public SpriteRenderer sr3;
    public SpriteRenderer sr4;

    public void OnClick()
    {
        isSelect = true;
        button1.isSelect = false;
        button2.isSelect = false;
    }


    private void Update()
    {
        if(isSelect)
        {
            sr1.color = new Color(255, 255, 0);
            sr2.color = new Color(255, 255, 0);
            sr3.color = new Color(255, 255, 0);
            sr4.color = new Color(255, 255, 0);
        }
        else
        {
            sr1.color = new Color(255, 255, 255);
            sr2.color = new Color(255, 255, 255);
            sr3.color = new Color(255, 255, 255);
            sr4.color = new Color(255, 255, 255);
        }
    }

}
