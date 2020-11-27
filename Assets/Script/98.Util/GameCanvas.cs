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

    public int startX;
    public int finishX;

    public GameObject endUI;
    public Slider mapclear;
    public TextMeshProUGUI percentage;
    public TextMeshProUGUI Coins;


    private void Start()
    {
        HPBar = GetComponentInChildren<Slider>();
        tmp = GetComponentInChildren<TextMeshProUGUI>();
        HPBar.maxValue = 100 + CharacterMgr.Instance.HPUpgrade * 10;
        HPBar.value = HPBar.maxValue;

        endUI.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    void Update()
    {

        if (CharacterMgr.Instance.IsRunning)
            SetSlider();
        else if (!endUI.activeSelf)
        {
            try
            {
                endUI.SetActive(true);
                mapclear.maxValue = finishX - startX;
                mapclear.value = ((int)player.transform.position.x - startX);
                percentage.text = ((int)((1 - ((mapclear.maxValue - mapclear.value) / mapclear.maxValue)) * 100)).ToString() + "%";
                CharacterMgr.Instance.Coin += GameMgr.Instance.GameCoin;
                Coins.text = "Coins : " + GameMgr.Instance.GameCoin.ToString();
                Destroy(player.gameObject);
            }
            catch { }

        }
  
    }

    private void SetSlider()
    {
        try
        {
            if (HPBar.value >= 0)
                HPBar.value = player.HP;

            tmp.text = GameMgr.Instance.GameCoin.ToString();
        }
        catch {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        }

    }
}
