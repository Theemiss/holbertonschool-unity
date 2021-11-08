
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Timer timer = collider.GetComponent<Timer>();
            timer.enabled = true;
            timer.timerchecker(true);

        }

    }
}
