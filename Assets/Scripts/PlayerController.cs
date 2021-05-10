using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D theRB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // float newXPosition = transform.position.x + (Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime);
        // float newYPosition = transform.position.y + (Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime);

        // transform.position = new Vector3(newXPosition, newYPosition, transform.position.z);

        float newXPosition = Input.GetAxisRaw("Horizontal");
        float newYPosition = Input.GetAxisRaw("Vertical");

        theRB.velocity = new Vector2(newXPosition, newYPosition).normalized * moveSpeed;
    }
}
