using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class MainMenu : MonoBehaviour
{
    
    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }
    public void Options()
    {
        SceneManager.LoadScene(4);

    }
    public void history()
    {
        int numbOfCompletedLevels = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previous", numbOfCompletedLevels);
    }
    public void Exit()
    {
        Debug.Log("Exited");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
