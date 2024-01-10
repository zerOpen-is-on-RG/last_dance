using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour
{
    public float speed = 5f;
    private float time;
    public GameObject go;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
             if (Input.GetKey(KeyCode.Keypad4)) {        
                transform.Translate(-speed * Time.deltaTime, 0, 0);           
              }
            if (Input.GetKey(KeyCode.Keypad6)) {
              transform.Translate(speed * Time.deltaTime, 0, 0);           
            }

        if (Input.GetKey(KeyCode.Keypad5))
        {
            if (time > 3f)
            {
                Instantiate(go, transform.position - new Vector3(0, 0, 2), Quaternion.identity);
                time = 0.0f;
            }
        }
      
    }
}
