using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerNameScript : MonoBehaviour
{
    public static PlayerNameScript Instance;
    public string playerName;
    [SerializeField] private InputField nameInput;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        
        
    }
    public void ProceedToMain()
    {
        playerName = nameInput.text;
        SceneManager.LoadScene("main");
    }
}
