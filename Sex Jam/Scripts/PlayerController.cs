using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.WSA;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0, ver) * speed * Time.deltaTime;
        transform.Translate(playerMovement,Space.Self);


    }
}
