using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{

    private float x_pos;
    private float y_pos;
    private float moving_speed;
    private float rot_speed;

    public GameObject obj;


    void Start()
    {
        this.moving_speed = 10.0f;
        this.rot_speed = 40.0f;
    }
    // Update is called once per frame
    void Update()
    {
        Translation();
        //Rotation();
        Shoot();
    }

    void Translation()
    {
        float keyHorizontal = Input.GetAxis("Horizontal");
        float keyVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * this.moving_speed * Time.smoothDeltaTime * keyHorizontal, Space.World);
        transform.Translate(Vector3.up * this.moving_speed * Time.smoothDeltaTime * keyVertical, Space.World);

    }

    void Rotation()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * this.rot_speed * Time.deltaTime;
        v = v * this.rot_speed * Time.deltaTime;


        transform.Rotate(Vector3.back * h);
        transform.Rotate(Vector3.right * v);
    }

    void Shoot()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("space pressed");
            Instantiate(obj, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }
}
