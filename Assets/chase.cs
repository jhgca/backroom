using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using System;
using Unity.VisualScripting;

public class chase : MonoBehaviour
{
    public GameObject ouch;
    public GameObject target;
    private Rigidbody2D rb;
    public float minspeed, maxspeed;
    public float timetomax;
    private Seeker seeker;
    private float startTime;
    public int health;
    public IAstarAI ai;
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
       
    }
    public void hurt(int amount)
    {
        health -= amount;
        Instantiate(ouch, transform.position, Quaternion.identity);
        if (health < 0)
        {
            GameManager.main.WinGame();
            Destroy(this.gameObject);
        }
    }
}
