using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        Vector3 coinInput = new Vector3(xInput, 0, yInput);
        coinInput = coinInput.normalized;
        transform.position += coinInput * speed * Time.deltaTime;
        if (coinInput.sqrMagnitude > 0)
        {
            transform.rotation = Quaternion.LookRotation(coinInput);
        }
        

        
    }
}
