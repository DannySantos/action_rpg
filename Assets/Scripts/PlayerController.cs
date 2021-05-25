using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D theRB;
    public SpriteRenderer theSR;
    public Sprite[] playerDirectionSprites;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
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

        anim.SetFloat("Speed", theRB.velocity.magnitude);

        if(theRB.velocity != Vector2.zero)
        {
            if(Input.GetAxisRaw("Horizontal") != 0)
            {
                theSR.sprite = playerDirectionSprites[1];

                if(Input.GetAxisRaw("Horizontal") < 0)
                {
                    theSR.flipX = true;
                } else 
                {
                    theSR.flipX = false;
                }
            } else
            {
                if(Input.GetAxisRaw("Vertical") < 0)
                {
                    theSR.sprite = playerDirectionSprites[0];
                } else
                {
                    theSR.sprite = playerDirectionSprites[2];
                }
            }
        }
    }
}
