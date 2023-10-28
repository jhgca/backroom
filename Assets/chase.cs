using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using UnityEditor.Experimental.GraphView;
using System;

public class chase : MonoBehaviour
{
    public GameObject target;
    private Rigidbody2D rb;
    public float minspeed, maxspeed;
    public float timetomax;
    private Seeker seeker;
    private float startTime;
    //private Path path;
    //public int currentwaypoint = 0;
    //private bool reachedendofpath = false;
    //public Vector2 direction;
    //public Vector3 currtarget;
    public IAstarAI ai;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        seeker = GetComponent<Seeker>();
        ai = GetComponent<IAstarAI>();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float currtime = (Time.time - startTime);
        float currspeed = Mathf.Lerp(minspeed, maxspeed, (currtime)/timetomax);
        GameManager.main.countdown((int)currtime);
        ai.maxSpeed = currspeed;
        Vector3 destination = target.transform.position;
        ai.destination = destination;
        //seeker.StartPath(transform.position, destination, OnPathComplete);
        //if (path != null ) 
        //{
        //    if (currentwaypoint >= path.vectorPath.Count) 
        //    {
        //        reachedendofpath = true;
        //    }
        //    else
        //    {
        //        reachedendofpath = false;
        //        currtarget = path.vectorPath[currentwaypoint] - transform.position;
        //        direction = currtarget.normalized;

        //    }
        //}
        
        //rb.velocity = direction * speed;
    }
    //void OnPathComplete(Path p)
    //{
    //    if (!p.error)
    //    {
    //        path = p;
    //        currentwaypoint = 1;
    //        reachedendofpath = false;
    //    }
    //}
}
