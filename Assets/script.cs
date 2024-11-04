using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class script : MonoBehaviour
{
    public GameObject parent;
    public GameObject Child;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnDrawGizmos()
    {
        float maxRange = 5;
        var heading = Child.transform.position - parent.transform.position;
        heading.y = 0;
        
        var distance = heading.magnitude;
        var direction = heading.normalized;
        if (distance < maxRange)
        {
            parent.transform.forward = heading;
            Gizmos.color = Color.green;
            Gizmos.DrawLine(parent.transform.position, direction * 2);
        }
        else
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(parent.transform.position, direction * 2);
        }
        
    }
    public static void DrawLine(Vector3 heading, Vector3 direction)
    {
      
        
    }
}
