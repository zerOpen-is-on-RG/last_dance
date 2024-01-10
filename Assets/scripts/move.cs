using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public float Speed = 10.0f;    
    public Text d;
    float h, v;
    public GameObject panel;
    public GameObject panel2;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            panel.SetActive(true);
        }
        if(transform.position.y > 7.5)
        {
            d.text = "GameClear";
            d.color = Color.green;
            panel.SetActive(true);
            panel2.SetActive(false);
        }
        if (Input.GetKey(KeyCode.R))
        {
            panel .SetActive(false);
            transform.position = new Vector3(1.19f, 0.8f, -0.85f);
        }
    }
    void FixedUpdate()
    {
        // Point 1.
        h = Input.GetAxis("Horizontal");        // 가로축
        v = Input.GetAxis("Vertical");          // 세로축

        // Point 2.
        transform.position += new Vector3(h, 0, v) * Speed * Time.deltaTime;
    }
   
}
