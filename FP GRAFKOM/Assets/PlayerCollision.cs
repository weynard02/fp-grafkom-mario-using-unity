using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public AudioSource playSound;
    void OnCollisionEnter (Collision collisionInfo) {

        if (collisionInfo.collider.tag == "Obstacle") {
            
            Debug.Log(collisionInfo.collider.name);


        }

        else if (collisionInfo.collider.tag == "Coin") {
            playSound.Play();
            Destroy(collisionInfo.gameObject);
        }
    }
}
