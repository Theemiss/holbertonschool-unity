using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Transform Player;
    private Timer time;
    private Text timeText;
    public Canvas Winncanvas;
    public Text WinText;

    private void Start()
    {
        time = Player.GetComponent<Timer>();
        Winncanvas.enabled = false;
        timeText = time.TimerText;
    }
    private void OnTriggerEnter(Collider win)
    {
        if (win.tag == "Player")
        {
            fuckingwin();
            WinText.text = timeText.text;
            Winncanvas.enabled = true;
        }
    }
    public void fuckingwin()
    {
        timeText.fontSize = 80;
        timeText.color = Color.green;
        time.timerchecker(false);
     
        
        

    }

}
