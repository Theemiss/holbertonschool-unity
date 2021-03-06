
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using static UnityEngine.Color;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    private int score = 0;
    public int health = 5;
    public Text scoreText;
    public Text healthText;
    public Image winLoseBG;
    public Text winLoseText;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            this.score++;
            SetScoreText();
            Destroy(other.gameObject);

        }
        if (other.tag == "Trap")
        {
            health--;
            SetHealthText();
        }
        if (other.tag == "Goal")
        {

            Win();
            StartCoroutine(LoadScene(3));

        }
    }
    void Win()
    {
        winLoseBG.color = new Color32(0, 255, 0, 255);
        winLoseText.color = new Color32(0, 0, 0, 255);
        winLoseText.text = "You Win!";
        winLoseBG.gameObject.SetActive(true);
    }


    void SetHealthText()
    {
        healthText.text = "Health: " + this.health;
    }
    void SetScoreText()
    {
        scoreText.text = "Score : " + this.score;

    }
    void Lose()
    {
        winLoseBG.color = new Color32(255, 0, 0, 255);
        winLoseText.color = new Color32(255, 255, 255, 255);
        winLoseText.text = "Game Over!";
        winLoseBG.gameObject.SetActive(true);
    }

    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("Maze");
        score = 0;
        health = 5;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
         float forwordForce = this.speed;
         float backwordForce = this.speed * -1;
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(forwordForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            rb.AddForce(0, 0, forwordForce * Time.deltaTime);
        }
        if (Input.GetKey("s")|| Input.GetKey("down"))
        {
            rb.AddForce(0, 0, backwordForce * Time.deltaTime);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(backwordForce * Time.deltaTime, 0, 0);
        }
    }
    void Update()
    {
        if (Input.GetButton("Cancel"))
        {
            SceneManager.LoadScene("menu");
        }
        if (health == 0)
        {
            Lose();
            StartCoroutine(LoadScene(3));
        }
    }
  
}
