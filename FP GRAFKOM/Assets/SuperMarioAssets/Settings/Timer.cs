using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public float currentTime;
    private bool isFinished = false;

    void Update()
    {
        if (!isFinished)
        {
            currentTime += Time.deltaTime;
            timerText.text = currentTime.ToString();
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Finish")
        {
            Debug.Log(collisionInfo.collider.name);
            isFinished = true;
        }
    }
}
