using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaypointMover : MonoBehaviour
{
    private Rigidbody rb;

    private List<Vector3> waypoints = new List<Vector3>();

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        foreach(Transform childTransform in this.transform)
        {
            if (!childTransform.CompareTag("Waypoint")) continue;

            waypoints.Add(childTransform.position);
        }

        transform.position = waypoints[0];

        StartCoroutine(MoveBetweenWaypoints());
    }

    IEnumerator MoveBetweenWaypoints()
    {
        while (true)
        {
            for (int i = 0; i < waypoints.Count; i++)
            {
                while (Vector3.Distance(rb.position, waypoints[i]) > .001f)
                {
                    rb.MovePosition(Vector3.MoveTowards(rb.position, waypoints[i], speed * Time.deltaTime));

                    yield return null;
                }
                yield return new WaitForSecondsRealtime(1f);
            }
        }
    }
}
