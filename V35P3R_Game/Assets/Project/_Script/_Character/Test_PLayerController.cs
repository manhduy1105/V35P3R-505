using UnityEngine;

public class Test_PLayerController : MonoBehaviour
{
    private Rigidbody rb;
    public bool canMove = true;
    public float playerSpeed = 5f;
    public float grafityScale = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        canMove = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            PlayerMove();
        }
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector3(x * playerSpeed, 0, z*playerSpeed);
        PlayerJump();   
    }
    void PlayerJump() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * grafityScale,ForceMode.Impulse);
        }
    }
}
