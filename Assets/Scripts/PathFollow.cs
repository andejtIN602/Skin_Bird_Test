// Author: Jamie Anderson//
// Reference Code: https://www.youtube.com/watch?v=fvdRKS8x0aM //
// https://answers.unity.com/questions/1003886/play-audio-clip-after-timer.html //
// D.O.C: 12/03/2020 //
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script's function is to allow a in-game entity to follow a pre-determined path.//
//This is implemented by using markers that are defined as waypoints for whatever is assigned to this script will follow.//
public class PathFollow : MonoBehaviour
{
    public Transform[] path;
    public float speed = 1.0f;
    public float reachDist = 1.0f;
    public int currentPoint = 0;

    public void Update()
    {
        //Vector3 dir = path [currentPoint].position - transform.position;
        float dist = Vector3.Distance(path[currentPoint].position, transform.position);
        //transform.position += dir * Time.deltaTime * speed;
        transform.position = Vector3.MoveTowards(transform.position, path[currentPoint].position, Time.deltaTime * speed);

        if (dist <= reachDist)
        {
            currentPoint++;
        }
        if (currentPoint >= path.Length)
        {
            currentPoint = 0;
        }
    }

    private void OnDrawGizmos()
    {
        if (path.Length > 0)
        for (int i = 0; i < path.Length; i++)
        {
            if (path[i] != null)
            {
                Gizmos.DrawSphere(path[i].position, reachDist);
            }
        }
    }
}




        