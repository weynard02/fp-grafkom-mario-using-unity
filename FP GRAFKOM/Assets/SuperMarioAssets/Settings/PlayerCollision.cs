using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    public AudioSource playSound;
    public AudioSource mainTheme;
    public AudioSource win;
    public AudioSource respawn;

    public TMP_Text scoreText;

    private int scoreNum;

    public GameObject complete;
    public GameObject character;

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

        else if (collisionInfo.collider.tag == "Monster") {
            character.transform.position = new Vector3(447f, 10.9f, 199.84f);
            respawn.Play();
        }

        else if (collisionInfo.collider.tag == "Finish" && !complete.activeSelf) {
            complete.SetActive(true);
            mainTheme.Stop();
            win.Play();
            movement.enabled = false;
        }
    }
}
