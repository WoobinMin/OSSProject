using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBtn : MonoBehaviour
{
    public SetCharButtons btn1;
    public SetCharButtons btn2;
    public SetCharButtons btn3;


    public void ChangeChar()
    {
        if (btn1.isSelect)
            CharacterMgr.Instance.Charselect = (int)CharSelect.Boy;
        else if(btn2.isSelect)
            CharacterMgr.Instance.Charselect = (int)CharSelect.Cat;
        else
            CharacterMgr.Instance.Charselect = (int)CharSelect.Dog;

        SceneMgr.Instance.SceneChange("1.LobbyScene");
    }



}
