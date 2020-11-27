using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasMgr : MonoBehaviour
{
    private static CanvasMgr instance;
    public static CanvasMgr Instance => instance;

    public GameObject cfadeinout;
    public GameObject cSettingButton;
    public GameObject cBackButton;
    public GameObject cCoinUI;


    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this);
    }


    void Start()
    {
    }

    private void Update()
    {

        if(CharacterMgr.Instance.IsRunning)
        {
            cSettingButton.gameObject.SetActive(false);
            cBackButton.gameObject.SetActive(false);
            cCoinUI.gameObject.SetActive(false);
        }
        else if(CharacterMgr.Instance.SeeUI)
        {
            cSettingButton.gameObject.SetActive(true);
            cBackButton.gameObject.SetActive(true);
            cCoinUI.gameObject.SetActive(true);
            cCoinUI.GetComponentInChildren<TextMeshProUGUI>().text = CharacterMgr.Instance.Coin.ToString();
        }


    }
}
