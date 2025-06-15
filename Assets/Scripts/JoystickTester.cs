using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickTester : MonoBehaviour
{

    public int numJoysticks = 1;
    public bool checkJoysticks = true;
    public bool checkKeys = true;
    public bool checkMouse = true;
    public float updateFrequency = 1f;

    private Vector3 mousePos;

    private Vector3 mousePosDelta;

    private bool mouseClicked;

    private void Update()
    {
        if (checkJoysticks) doCheckJoysticks();

        if (checkKeys) doCheckKeys();

        if (checkMouse) doCheckMouse();
    }

    void doCheckJoysticks()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        bool fire1 = Input.GetButtonDown("Fire1");
        bool fire2 = Input.GetButtonDown("Fire2");
        bool fire3 = Input.GetButtonDown("Fire3");

        Debug.Log(horizontalInput + ", " + verticalInput + ", " + fire1 + ", " + fire2 + ", " + fire3);
    }

    void doCheckKeys()
    {
        if (Input.anyKeyDown)
        {
            foreach (KeyCode keyCode in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    Debug.Log("Keypress: " + keyCode.ToString());
                }
            }
        }
    }

    void doCheckMouse()
    {
        mousePos = Input.mousePosition;
        mousePosDelta.x = Input.GetAxis("Mouse X");
        mousePosDelta.y = Input.GetAxis("Mouse Y");
        mouseClicked = Input.GetMouseButton(0);

        Debug.Log("Mouse: x " + mousePosDelta.x + " -> " + mousePos.x + ", y " + mousePosDelta.y + " -> " + mousePos.y + ", " + mouseClicked);
    }
   
}
