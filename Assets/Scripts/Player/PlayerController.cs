using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public Joystick joistick;
    public float moveSpeed;
    float horizontalMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(joistick.Horizontal > 0.5f || joistick.Horizontal < -0.5f)
        {
            transform.Translate(new Vector3(joistick.Horizontal * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        if (joistick.Vertical > 0.5f || joistick.Vertical < -0.5f)
        {
            transform.Translate(new Vector3(0f, joistick.Vertical * moveSpeed * Time.deltaTime, 0f));
            
            
        }

        if (Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("Battle", LoadSceneMode.Additive);
        }

    }
}
