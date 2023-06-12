using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1f;

    [SerializeField]
    private float interval = 3.84f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x -= moveSpeed * Time.deltaTime;

        if (pos.x < -interval)
            pos.x += interval;

        transform.position = pos;
    }
}
