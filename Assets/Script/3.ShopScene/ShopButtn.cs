using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopButtn : MonoBehaviour
{
    public TextMeshProUGUI cost;

    public void Update()
    {
        try { cost.text = "비용 : " + (50 + CharacterMgr.Instance.HPUpgrade * 5).ToString(); }
        catch { }
    }


    public void HPUpGrade()
    {
        if(CharacterMgr.Instance.Coin >= 50 + CharacterMgr.Instance.HPUpgrade * 5)
        {
            CharacterMgr.Instance.HPUpgrade += 1;
            CharacterMgr.Instance.Coin -= 50  + CharacterMgr.Instance.HPUpgrade * 5;
        }
    }

    public void BackBtn()
    {
        SceneMgr.Instance.SceneChange("1.LobbyScene");
    }
}

