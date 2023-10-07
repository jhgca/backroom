using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using UnityEditor.Experimental.GraphView;

public class chase : MonoBehaviour
{
    public GameObject target;
    private Rigidbody2D rb;
    public float speed;
    private Seeker seeker;
    private Path path;
    public int currentwaypoint = 0;
    private bool reachedendofpath = false;
    public Vector2 direction;
    public Vector3 currtarget;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        seeker = GetComponent<Seeker>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 destination = target.transform.position;
        seeker.StartPath(transform.position, destination, OnPathComplete);
        if (path != null ) 
        {
            if (currentwaypoint >= path.vectorPath.Count) 
            {
                reachedendofpath = true;
            }
            else
            {
                reachedendofpath = false;
                currtarget = path.vectorPath[currentwaypoint] - transform.position;
                direction = currtarget.normalized;

            }
        }
        
        rb.velocity = direction * speed;
    }
    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentwaypoint = 1;
            reachedendofpath = false;
        }
    }
}
