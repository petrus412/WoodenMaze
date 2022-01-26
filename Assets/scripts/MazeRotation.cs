using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRotation : MonoBehaviour
{
    private Gyroscope m_Gyro;
    Quaternion fix;
    // Start is called before the first frame update
    void Awake ()
    {
        m_Gyro=Input.gyro;
        m_Gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion Rotation = Quaternion.Euler(m_Gyro.attitude.eulerAngles.x, 0, m_Gyro.attitude.eulerAngles.y);
        gameObject.transform.rotation = Rotation;
        fix = Rotation;
        print(Screen.orientation);
        if (gameObject.transform.eulerAngles.x < 350 && gameObject.transform.eulerAngles.x > 180)
        {
            fix = Quaternion.Euler(-10, 0 ,gameObject.transform.rotation.eulerAngles.z);
            gameObject.transform.rotation = fix;
        }
        if (gameObject.transform.eulerAngles.x > 10 && gameObject.transform.eulerAngles.x < 180)
        {
            fix = Quaternion.Euler(10, 0, gameObject.transform.rotation.eulerAngles.z);
            gameObject.transform.rotation = fix;
        }
        if (gameObject.transform.eulerAngles.z < 350 && gameObject.transform.eulerAngles.z > 180)
        {
            fix = Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, 0, -10);
            gameObject.transform.rotation = fix;
        }
        if (gameObject.transform.eulerAngles.z > 10 && gameObject.transform.eulerAngles.z < 180)
        {
            fix = Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, 0, 10);
            gameObject.transform.rotation = fix;
        }
    }

 
}

