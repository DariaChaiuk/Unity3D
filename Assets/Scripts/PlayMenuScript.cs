using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
 
 
public class PlayMenuScript : MonoBehaviour
{
    public void Update(){
        if(Input.GetKeyDown("escape")) {
            SceneManager.LoadScene("Scenes/Menu");
        }
    }

    public void PlayGame()
    {
        PlayerPrefs.SetString("CurrentLevel", "Scenes/Level_1");
        SceneManager.LoadScene("Scenes/Level_1");
    }
    public void AboutGame()
    {
        SceneManager.LoadScene("Scenes/About");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Scenes/Settings");
    }
    public void Levels(){
        SceneManager.LoadScene("Scenes/Levels");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }
    public void Level1()
    {
        PlayerPrefs.SetString("CurrentLevel", "Scenes/Level_1");
        SceneManager.LoadScene("Scenes/Level_1");
    }
    public void Level2()
    {
        PlayerPrefs.SetString("CurrentLevel", "Scenes/Level_2");
        SceneManager.LoadScene("Scenes/Level_2");
    }
    public void ControlButtons()
    {
        SceneManager.LoadScene("Scenes/ControlButtons");
    }
    public void Quit()
    {
        #if UNITY_STANDALONE
            Application.Quit();
        #endif
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
    public void Resume(){
        String currentScene = PlayerPrefs.GetString("CurrentLevel");
        if(currentScene!= null){
            SceneManager.LoadScene(currentScene);
        }
    }
    public void Win(){
        SceneManager.LoadScene("Scenes/Win");
    }
}
