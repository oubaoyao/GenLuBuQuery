using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MTFrame;

public class BgAnimation : MonoBehaviour
{
    public Transform transform1, transform2;
    private float RotateSpeed = 2.0f;
    public BasePanel basePanel;

    // Update is called once per frame
    void Update()
    {
        if( basePanel!=null && basePanel.IsOpen)
        {
            transform1.Rotate(Vector3.forward);
            //transform2.Rotate(Vector3.forward);
        }
    }
}
