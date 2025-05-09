using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Transform point_1;
    [SerializeField] private Transform point_2;
    private Vector3 target;
    [SerializeField] private float speed;   
    [SerializeField] private bool isGo;


    // Start is called before the first frame update
    void Start()
    {
        //Vector3 vector3 = transform.position;
        //vector3.y = -11.10001f;
        //vector3.x = 0;
        //vector3.z = 0;
        //transform.position = vector3;
        //target = point_1.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target);

        if (isGo)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, point_1.position, Time.deltaTime * speed);
        }

        //if (transform.localPosition == target)
        //{
        //    if (target == point_1.localPosition)
        //        target = point_2.localPosition;
        //    else
        //        target = point_1.localPosition;
        //}
    }
}
