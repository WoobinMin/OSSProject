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
            CharacterMgr.Instance.Charcolor = (int)CharColor.Original;
        else if(btn2.isSelect)
            CharacterMgr.Instance.Charcolor = (int)CharColor.Green;
        else
            CharacterMgr.Instance.Charcolor = (int)CharColor.Purple;

        SceneMgr.Instance.SceneChange("1.LobbyScene");
    }



}
