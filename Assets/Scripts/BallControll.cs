using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    public float speed;
    private Rigidbody mybody;
    
    // Start is called before the first frame update
    void Start()
    {
        mybody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
     

        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 vector = new Vector3(yatay, 0, dikey);

        mybody.AddForce(vector*speed);

    }
}
