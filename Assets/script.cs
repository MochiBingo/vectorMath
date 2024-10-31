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
        int maxRange = 10;
        var heading = parent.transform.position - Child.transform.position;
        heading.y = 0;
        var distance = heading.magnitude;
        var direction = heading.normalized;
        if (heading.sqrMagnitude < maxRange * maxRange)
        {
            
        }
    }
    private void OnDrawGizmos()
    {
        
    }
    public static void DrawLine(Vector3 heading, Vector3 direction)
    {
      
        
    }
}
