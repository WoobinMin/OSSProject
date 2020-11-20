using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameCanvas : MonoBehaviour
{
    private Slider HPBar;
    private Player player;
    private TextMeshProUGUI tmp;

    private void Start()
    {
        HPBar = GetComponentInChildren<Slider>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        tmp = GetComponentInChildren<TextMeshProUGUI>();
        HPBar.maxValue = 100 + CharacterMgr.Instance.HPUpgrade * 10;
        HPBar.transform.localScale = new Vector3(HPBar.maxValue * 5f / 100f, HPBar.transform.localScale.y, HPBar.transform.localScale.z);
        HPBar.value = HPBar.maxValue;
    }

    void Update()
    {
        SetSlider();
    }

    private void SetSlider()
    {
        if(HPBar.value >= 0)
            HPBar.value = player.HP;

        tmp.text = GameMgr.Instance.GameCoin.ToString();
    }
}
