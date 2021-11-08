using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Transform Player;
    private Timer time;
    private Text timeText;

    private void Start()
    {
        time = Player.GetComponent<Timer>();
        timeText = time.TimerText;
    }
    private void OnTriggerEnter(Collider win)
    {
        if (win.tag == "Player")
        {
            fuckingwin();
        }
    }
    public void fuckingwin()
    {
        timeText.fontSize = 80;
        timeText.color = Color.green;
        time.timerchecker(false);
    }

}
