using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickTester : MonoBehaviour {

    public float updateFrequency = 1f;
    private IEnumerator Start() {
        while (true) {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            bool fire1 = Input.GetButtonDown("Fire1");
            bool fire2 = Input.GetButtonDown("Fire2");
            bool fire3 = Input.GetButtonDown("Fire3");
            Debug.Log(horizontalInput + ", " + verticalInput + ", " + fire1 + ", " + fire2 + ", " + fire3);

            yield return new WaitForSeconds(updateFrequency);
        }
    }

}
