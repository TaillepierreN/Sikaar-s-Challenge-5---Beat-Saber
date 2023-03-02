using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBehavior : MonoBehaviour
{
    public LayerMask layer;
    Vector3 previousPos;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward,out hit,1,layer))
        {
            if(Vector3.Angle(transform.position-previousPos,hit.transform.up)>130)
            {
                Destroy(hit.transform.gameObject);
            }
        }
        previousPos = transform.position;
        
    }
        void OnDrawGizmosSelected()
    {
        // Draws a 5 unit long red line in front of the object
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.forward);
        Gizmos.DrawRay(transform.position, direction);
    }
}
