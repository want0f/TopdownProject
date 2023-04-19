using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshoot : MonoBehaviour
{
    [SerializeField]
    private float damage = 1f;
    [SerializeField]
    private float range = 100f;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        RaycastHit hit; 
        if(Physics.Raycast(player.transform.position, player.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
