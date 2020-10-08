using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgr : MonoBehaviour
{
    private static SceneMgr instance;
    public static SceneMgr Instance => instance;

    private string sceneName;
    public string SceneName { get => sceneName; set => sceneName = value; }


    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }


    public void SceneChange(string _SceneName)
    {
        sceneName = _SceneName;
        CanvasMgr.Instance.cfadeinout.gameObject.SetActive(true);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }

}