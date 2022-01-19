using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class OptionsMenu : MonoBehaviour
{
    private bool tage;
    public Toggle isinver;
    public void history()
    {
        int numbOfCompletedLevels = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previous", numbOfCompletedLevels);
    }
    public void Back()
    {

        int numbOfCompletedLevels = PlayerPrefs.GetInt("previous", 0);
        SceneManager.LoadScene(numbOfCompletedLevels);

    }
    public void Apply()
    {
        Invert();
        Back();
    }
    public void Invert()
    {
        tage = isinver.isOn;
        if (tage)
        {
            PlayerPrefs.SetInt("__inverted",1);

        }
        else
        {
            PlayerPrefs.SetInt("__inverted",0);

        }
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
