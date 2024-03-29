using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    public Vector3 ReadInput()
    {
        float x = 0f;

        if (Input.GetKey(KeyCode.LeftArrow)) x = -1;

        else if (Input.GetKey(KeyCode.RightArrow)) x = 1;

        float y = 0f;

        if (Input.GetKey(KeyCode.UpArrow)) y = 1;

        else if(Input.GetKey(KeyCode.DownArrow)) y = -1;

        if (x != 0 || y != 0)
        {
            Vector3 direction = new Vector3(x, y, 0f);
            return direction;
        }

        return Vector3.zero;

    }

    internal bool ReadUndo()
    {
        return Input.GetKey(KeyCode.Space);
    }

    internal float ReadScale()
    {
        if (Input.GetKey(KeyCode.Q))
            return 1f;
        if (Input.GetKey(KeyCode.E))
            return -1f;

        return 0f;
    }
}
