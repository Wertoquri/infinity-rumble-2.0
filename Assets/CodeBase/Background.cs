using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float shiftDistatnce = 10.5f;
    private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 transformPosition = transform.position;
        if(mainCamera.transform.position.y - transform.position.y >= shiftDistatnce)
        {
            transformPosition.y = mainCamera.transform.position.y;
        }
        transform.position = transformPosition;
    }
}
