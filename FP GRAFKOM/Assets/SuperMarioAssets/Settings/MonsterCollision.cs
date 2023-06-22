using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCollision : MonoBehaviour
{
    public float speed;
    public bool isMoveRight;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (isMoveRight) {
            transform.Translate(0, 0, -2* Time.deltaTime * speed);
        }
        else {
            transform.Translate(0, 0, 2*Time.deltaTime*speed);
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Obstacle") {
            if (isMoveRight) {
                // Debug.Log(collision.collider.name);
                // Debug.Log("Got hit");
                isMoveRight = false;
                // Debug.Log("Move Right" + isMoveRight);
            }
            else {
                // Debug.Log(collision.collider.name);
                // Debug.Log(" Got hit");
                isMoveRight = true;
                // Debug.Log("Move Right" + isMoveRight);
            }
        }
    }
}
