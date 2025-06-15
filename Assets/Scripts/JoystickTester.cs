using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickTester : MonoBehaviour
{

    public bool checkKeys = true;
    public bool checkJoysticks = true;
    public bool checkMouse = true;
    public float updateFrequency = 1f;

    private IEnumerator Start()
    {
        while (true)
        {
            if (checkJoysticks) doCheckJoysticks();

            if (checkKeys) doCheckKeys();

            if (checkMouse) doCheckMouse();

            yield return new WaitForSeconds(updateFrequency);
        }
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
                    Debug.Log("Key Pressed: " + keyCode.ToString());
                }
            }
        }
    }

    void doCheckMouse()
    {
        
    }

}
