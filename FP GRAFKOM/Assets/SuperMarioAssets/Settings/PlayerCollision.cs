using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    public AudioSource playSound;
    public AudioSource mainTheme;
    public AudioSource win;

    public TMP_Text scoreText;

    private int scoreNum;

    public GameObject complete;

    public PlayerMovement movement;


    void Start() {
        scoreNum = 0;
        scoreText.text = scoreNum + "/21";
    }

    void OnCollisionEnter (Collision collisionInfo) {

        if (collisionInfo.collider.tag == "Obstacle") {
            
            Debug.Log(collisionInfo.collider.name);


        }

        else if (collisionInfo.collider.tag == "Coin") {
            playSound.Play();
            Destroy(collisionInfo.gameObject);
            scoreNum+=1;
            scoreText.text = scoreNum + "/21";
        }

        else if (collisionInfo.collider.tag == "Finish" && !complete.activeSelf) {
            complete.SetActive(true);
            mainTheme.Stop();
            win.Play();
            movement.enabled = false;
        }
    }
}
