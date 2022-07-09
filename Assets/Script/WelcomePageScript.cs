using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomePageScript : MonoBehaviour
{
    public GameObject MainMenuPanel;

    public GameObject LoadGamePanel;

    public GameObject GameNamePanel;

    public GameObject LevelText;

    public void OnNewGameClick()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnLoadGameClick()
    {
        LoadGamePanel.SetActive(true);
        MainMenuPanel.SetActive(false);
        GameNamePanel.SetActive(false);
    }

    public void OnBackButtonPress()
    {
        MainMenuPanel.SetActive(true);
        GameNamePanel.SetActive(true);
        LoadGamePanel.SetActive(false);
    }

    public void HandleLoadGameClick(int Level)
    {
        LevelText.GetComponent<TMP_Text>().text = "Level: " + Level;
        LoadGamePanel.SetActive(false);
    }

    private void Start()
    {
    }

    private void Update()
    {
    }
}
