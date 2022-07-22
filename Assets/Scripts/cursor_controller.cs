using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor_controller : MonoBehaviour
{
    public bool cursor_visible;

    // Start is called before the first frame update
    void Start()
    {
        cursor_visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = cursor_visible;
    }

    public void SetVisibleTrue()
    {
        cursor_visible = true;
    }

    public void SetVisibleFalse()
    {
        cursor_visible = false;
    }
}
