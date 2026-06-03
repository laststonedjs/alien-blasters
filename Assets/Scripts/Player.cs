using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        var vertical = rb.linearVelocityY;

        if (Input.GetButtonDown("Fire1"))
            vertical = 5;
        rb.linearVelocity = new Vector2(horizontal, vertical);
    }
}
