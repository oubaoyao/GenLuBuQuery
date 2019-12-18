using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulerControl : MonoBehaviour
{
    private Vector3 InitialPosition;
    // Start is called before the first frame update
    void Start()
    {
        InitialPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrag()
    {
        transform.position = Input.mousePosition;
    }

    public void EndDrag()
    {
        transform.localPosition = InitialPosition;
        transform.localEulerAngles = Vector3.zero;
    }
}
