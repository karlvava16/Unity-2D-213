using UnityEngine;

public class SquareScript : MonoBehaviour
{

    private Rigidbody2D rb2d; // посилання на компонент RigidBody2D

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // пошук компонента, одержання посилання
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * 300);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(Vector2.left * 5);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(Vector2.right * 5);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb2d.AddTorque(1);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            rb2d.angularVelocity = 0;
            rb2d.velocity = Vector2.zero;

            //rb2d.linearVelocity = Vector2.zero;
        }
    }
}
