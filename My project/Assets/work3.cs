using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class work3 : MonoBehaviour
{

    public Transform progectileCloneTemplate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Transform newTransform = Instantiate(progectileCloneTemplate, transform.position, transform.rotation);

            Rigidbody newObjectRigitBody = newTransform.GetComponent<Rigidbody>();
            work3 badScript =  newTransform.GetComponent<work3>();
            Destroy(badScript);

            newObjectRigitBody.AddExplosionForce(1000, transform.position - transform.forward - transform.up, 3);
        }
    }
}
