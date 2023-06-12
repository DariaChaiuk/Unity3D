using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Level : MonoBehaviour
{
   private PlayMenuScript playMenu;
   
    // Start is called before the first frame update
    void Start()
    {
        playMenu = FindObjectOfType<PlayMenuScript>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            String currentScene = PlayerPrefs.GetString("CurrentLevel");
            if(currentScene == "Scenes/Level_1"){
                playMenu.Level2();
            } else {
                playMenu.Win();
            }
            Debug.Log("Next Level");
        }
    }
}
