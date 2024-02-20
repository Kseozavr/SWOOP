using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour
{
    [SerializeField]
    private float speed = 50f;
    public float gravity = 9.8f;
    public float toplivo;
    public int collectedPoints = 0; 


    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (toplivo > 0)
        {

            if (Input.GetMouseButton(0))
            {
                toplivo -= Time.deltaTime;
                rb.velocity = new Vector2(rb.velocity.x, speed);
            }
            else
            {
                rb.velocity = new Vector2(rb.velocity.x, -gravity);
            }
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, -gravity);
        }
    }

    private void onTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Star"))
        {
            collectedPoints += other.gameObject.GetComponent<PrefStar>().Star;
        }
    }
}
