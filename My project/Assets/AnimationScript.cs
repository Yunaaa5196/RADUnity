using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{

    Animator myBearAnimator;
    float turningSpeed = 90f;

    // Start is called before the first frame update
    void Start()
    {
        myBearAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += 3 * transform.forward * Time.deltaTime;
            myBearAnimator.SetBool("isWalking", true);
        }
        else
            myBearAnimator.SetBool("isWalking", false);


        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turningSpeed*Time.deltaTime);  

            myBearAnimator.SetBool("isWalkingBackwards", true);
        }
        else
            myBearAnimator.SetBool("isWalkingBackwards", false);

    }
}
