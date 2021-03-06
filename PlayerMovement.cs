using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float mouseSpeed = 100f;
    public float controllerSpeed = 100f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;

    public Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.1f;
    public LayerMask groundMask;

   public bool isGrounded;
   
    //public bool groundSlam;
    //public ParticleSystem whiteSplatter;

    private void Start()
    {
        velocity.y = -2f;
        groundCheck = gameObject.transform.Find("GroundCheck");
    }

    void Update()
    {

        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        if (Input.GetButtonDown("GroundSlam") && isGrounded == false)
        {
            //groundSlam = true;
            velocity = Vector3.zero;
            velocity.y = gravity;
        }

        if (isGrounded == false && velocity.y > 0 || velocity.y < 0)
        {
            velocity.y += 2f * gravity * Time.deltaTime;
        }

        if (velocity.y < 0 && isGrounded == true)
        {
            velocity.y = -2f;
        }

        MouseMovement();

        ControllerMovement();
    }

    private void FixedUpdate()
    {
        RaycastHit ray;

        isGrounded = Physics.Raycast(groundCheck.position, Vector3.down, out ray, groundDistance, groundMask);

        Debug.DrawLine(groundCheck.position, ray.point, Color.red, 100f);
    }

    void MouseMovement()
    {
        float x = Input.GetAxis("Mouse Move X");
        float z = Input.GetAxis("Mouse Move Y");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * mouseSpeed * Time.deltaTime);

        controller.Move(velocity * Time.deltaTime);

    }

    void ControllerMovement()
    {
        float x = Input.GetAxis("Controller Move X");
        float z = Input.GetAxis("Controller Move Y");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * controllerSpeed * Time.deltaTime);

        controller.Move(velocity * Time.deltaTime);

    }

    /*
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Detected");

        if (groundSlam == true)
        {
            Debug.Log("Ground Slammed!");
            Instantiate(whiteSplatter, groundCheck.position, groundCheck.rotation);
        }

        groundSlam = false;
    }
    */
}
