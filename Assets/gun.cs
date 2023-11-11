using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform firespot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouspos = Input.mousePosition;
        Vector3 screenpos = Camera.main.ScreenToWorldPoint(mouspos);
        screenpos = new Vector3 (screenpos.x, screenpos.y, 0);
        transform.right = screenpos - transform.position;
    }
}
