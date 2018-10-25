using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragscript : MonoBehaviour {

    public GameObject gameObjectTodrag;

    public Vector3 GoCenter;
    public Vector3 touchPosition;
    public Vector3 offset;
    public Vector3 newGoCenter;

    RaycastHit hit;
    public bool draggingMode = false;

    void Start()
    {

    }


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                gameObjectTodrag = hit.collider.gameObject;
                GoCenter = gameObjectTodrag.transform.position;
                touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                offset = touchPosition - GoCenter;
                draggingMode = true;
            }
        }

        if (Input.GetMouseButton(0))
        {
            if (draggingMode)
            {
                touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                newGoCenter = touchPosition - offset;
                gameObjectTodrag.transform.position = new Vector3(newGoCenter.x, newGoCenter.y, GoCenter.z);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            draggingMode = false;
        }
    }
}
