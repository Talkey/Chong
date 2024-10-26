using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void Init()
    {
        InitGame();
        InitUI();
    }

    public void InitUI()
    {
        UIObject ui_instance = UIManager.OpenUI(UIData.StartUI);
        ui_instance.Init();
    }   
    
    public void InitGame()
    {

    }

    public void LoadScene(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }    
}
