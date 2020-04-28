using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Script : MonoBehaviour
{
    private float z_pos;
    public GameObject fx_obj;

    // Start is called before the first frame update
    void Start()
    {
        z_pos = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        z_pos = 0.1f;
        transform.Translate(0.0f, 0.0f, z_pos);

        Debug.Log(z_pos);

        Destroy(gameObject, 3);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy_Tag")
        {
            Debug.Log("collision");
            Destroy(gameObject, 0);
            Destroy(other.gameObject, 0);
            Instantiate(fx_obj, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }
}
