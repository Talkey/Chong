using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingleBase
{
    // Start is called before the first frame update
    private UIManager uiManager;
    public Transform UIRoot;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        Init();
    }

    public void Init()
    {
        InitGame();
        InitUI();
    }

    public void InitUI()
    {
        UIObject ui_instance = uiManager.OpenUI(UIData.StartUI);
        ui_instance.Init();
    }
    
    public void InitGame()
    {
        uiManager = new UIManager();
        if(UIRoot == null)
        {
            UIRoot = GameObject.Find("UIRoot").GetComponent<Transform>();
        }
        uiManager.UIRoot = this.UIRoot;
    }

    public void LoadScene(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }

    public float ShowLoading()
    {
        uiManager.OpenUI(UIData.LoadingUI);
        return 0f;
    }
}
