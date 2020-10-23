using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMgr : MonoBehaviour
{

    private static CharacterMgr instance;
    public static CharacterMgr Instance => instance;

    private int charcolor = (int)CharColor.Original;
    public int Charcolor { get => charcolor; set => charcolor = value; }

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

    private void Update()
    {
    }

}
