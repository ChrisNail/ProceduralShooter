using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float walkSpeed = 10.0f;

    private float runModifier = 2.0f;

    private float airModifier = 0.5f;

    private bool grounded = false;
    private bool running = false;

    private float lookSpeed = 2.0f;

    private float minRotationX = -360.0f;
    private float maxRotationX = 360.0f;
    private float minRotationY = -60.0f;
    private float maxRotationY = 60.0f;
    private float rotationX = 0.0f;
    private float rotationY = 0.0f;
    private Quaternion originalRotation;

    public GameObject playerCamera;

    // Use this for initialization
    void Start () {
        originalRotation = transform.localRotation;
    }
	
	// Update is called once per frame
	void Update () {
        //Read input values
        float strafe = Input.GetAxis("Horizontal") * Time.deltaTime;
        float walk = Input.GetAxis("Vertical") * Time.deltaTime;

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        running = Input.GetAxis("Run") > 0.0f;

        //Do mouse look

        rotationX += Input.GetAxis("Mouse X") * lookSpeed;
        rotationY += Input.GetAxis("Mouse Y") * lookSpeed;
        rotationX = ClampAngle(rotationX, minRotationX, maxRotationX);
        rotationY = ClampAngle(rotationY, minRotationY, maxRotationY);
        Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
        Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, -Vector3.right);

        playerCamera.transform.localRotation = originalRotation * xQuaternion * yQuaternion;

        //Setup movement

        grounded = CheckGrounded();

        strafe *= walkSpeed;
        walk *= walkSpeed;

        if(!grounded) {
            strafe *= airModifier;
            walk *= airModifier;
        }
        if (running) {
            walk *= runModifier;
        }

        Vector3 move = (playerCamera.transform.forward * walk) + (playerCamera.transform.right * strafe);
        GetComponent<Rigidbody>().AddForce(move, ForceMode.Impulse);
	}

    public bool CheckGrounded() {
        return true;
    }

    public float ClampAngle(float angle, float min, float max) {
        if (angle < -360.0f) {
            angle += 360.0f;
        } else if (angle > 360.0f) {
            angle -= 360.0f;
        }
        return Mathf.Clamp(angle, min, max);
    }
}
