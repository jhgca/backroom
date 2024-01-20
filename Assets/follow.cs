using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetposition = player.position;
        Vector3 mouspos = Input.mousePosition;
        Vector3 screenpos = Camera.main.ScreenToWorldPoint(mouspos);
        screenpos = new Vector3(screenpos.x, screenpos.y, 0);
        float distance = Vector3.Distance(targetposition, screenpos);
        Vector3 direction = (screenpos - targetposition).normalized;
        transform.position = targetposition + direction * (distance/2);
        transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
