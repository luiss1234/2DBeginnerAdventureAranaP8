using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float verticle = Input.GetAxis("Vertical");

        Vector2 position = transform.position;
        position.x = position.x + 8.0f * horizontal * Time.deltaTime;
        position.y = position.y + 8.0f * verticle * Time.deltaTime; ;

        transform.position = position;
        
    }
}
