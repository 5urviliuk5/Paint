using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painter : MonoBehaviour
{
    public GameObject lineObject;
    LineRenderer line;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            line = Instantiate(lineObject).GetComponent<LineRenderer>();
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            AddPoint();
        }

    }

    void AddPoint()
    {
        line.positionCount++;

        var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;

        line.SetPosition(line.positionCount - 1, worldPos);
    }
}
