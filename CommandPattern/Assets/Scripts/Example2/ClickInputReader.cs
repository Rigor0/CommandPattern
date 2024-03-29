using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInputReader : MonoBehaviour
{
    public Vector3? GetClickPosition()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo))
            {
                return hitInfo.point;
            }
        }

        return null;
    }
}
