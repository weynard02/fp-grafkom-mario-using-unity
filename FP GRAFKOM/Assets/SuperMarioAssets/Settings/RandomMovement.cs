using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Kecepatan pergerakan objek
    public float changeInterval = 2f; // Interval perubahan arah

    private float timer; // Timer untuk melacak waktu

    // Start is called before the first frame update
    void Start()
    {
        // Mulai timer
        timer = changeInterval;
    }

    // Update is called once per frame
    void Update()
    {
        // Kurangi timer
        timer -= Time.deltaTime;

        // Jika timer mencapai nol, ubah arah objek
        if (timer <= 0f)
        {
            ChangeDirection();
            // Atur ulang timer
            timer = changeInterval;
        }

        // Bergerak maju hanya di sumbu X dan Z
        Vector3 movement = new Vector3(transform.forward.x, 0f, transform.forward.z);
        transform.position += movement * moveSpeed * Time.deltaTime;
    }

    // Metode untuk mengubah arah objek secara acak
    void ChangeDirection()
    {
        // Menghasilkan nilai acak dalam rentang 0 hingga 360 derajat
        float randomAngle = Random.Range(0f, 360f);

        // Mengubah rotasi objek hanya pada sumbu Y (horizontal)
        transform.rotation = Quaternion.Euler(0f, randomAngle, 0f);
    }
}
