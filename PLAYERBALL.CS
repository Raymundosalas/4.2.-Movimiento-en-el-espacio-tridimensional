using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    public float bounceForce = 8f;
    private Rigidbody rb;
    private bool canJump = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canJump)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        canJump = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            canJump = true;
            GameManager.instance.AddScore(1);
        }
    }
}
