using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public Joystick joistick;
    public float moveSpeed;
    public bool acceptmovement;
    float horizontalMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            acceptmovement = true;
        }
        
        if (acceptmovement)
        {
            if (joistick.Horizontal > 0.1f || joistick.Horizontal < -0.1f)
            {
                transform.Translate(new Vector3(joistick.Horizontal * moveSpeed * Time.deltaTime, 0f, 0f));
            }

            if (joistick.Vertical > 0.1f || joistick.Vertical < -0.1f)
            {
                transform.Translate(new Vector3(0f, joistick.Vertical * moveSpeed * Time.deltaTime, 0f));


            }
        }
        

        if (Input.GetKeyDown(KeyCode.Escape)){
            Input.ResetInputAxes();
        }


    }
}
