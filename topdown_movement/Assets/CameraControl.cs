using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement charecter;
    [SerializeField]    
    private float followDistanceUP;
    [SerializeField] 
    private float followDistanceBack;

    [SerializeField]
    private Vector3 Offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = charecter.transform.position + Offset;
    }
}
