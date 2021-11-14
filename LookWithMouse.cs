using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookWithMouse : MonoBehaviour
{
    public float mouseSensitivityX = 3000f;
    public float controllerSensitivityX = 250f;
    public float mouseSensitivityY = 3000f;
    public float controllerSensitivityY = 250f;
    public Transform playerBody;

    float xRotation = 0f;
    float yRotation = 0f;

    public Slider controllerXBar;
    public Slider controllerYBar;

    public Slider mouseXBar;
    public Slider mouseYBar;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        /*
        controllerXBar.onValueChanged.AddListener(ApplySensitivity);
        controllerYBar.onValueChanged.AddListener(ApplySensitivity);
        mouseXBar.onValueChanged.AddListener(ApplySensitivity);
        mouseYBar.onValueChanged.AddListener(ApplySensitivity);
        */

    }

    void Update()
    {

        MouseControls();

        ControllerControls();

        /*
        controllerSensitivityX = controllerXBar.value;
        controllerSensitivityY = controllerYBar.value;

        mouseSensitivityX = mouseXBar.value;
        mouseSensitivityY = mouseYBar.value;
        */

    }

    void MouseControls()
    {
        float mouseX = Input.GetAxis("Mouse Look X") * mouseSensitivityX * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Look Y") * mouseSensitivityY * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    void ControllerControls()
    {
        float controllerX = Input.GetAxis("Controller Look X") * controllerSensitivityX * Time.deltaTime;
        float controllerY = Input.GetAxis("Controller Look Y") * controllerSensitivityY * Time.deltaTime;

        xRotation -= controllerY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        playerBody.Rotate(Vector3.up * controllerX);
    }

    public void ApplySensitivityXController(float controllerX)
    {

        controllerSensitivityX = controllerX;

    }

    public void ApplySensitivityYController(float controllerY)
    {

        controllerSensitivityY = controllerY;

    }

    public void ApplySensitivityXMouse(float mouseX)
    {

        mouseSensitivityX = mouseX;

    }

    public void ApplySensitivityYMouse(float mouseY)
    {

        mouseSensitivityY = mouseY;

    }
}
