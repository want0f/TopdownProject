using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class booletinstantiate : MonoBehaviour
{
    [SerializeField]
    private Rigidbody bullet;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float strength = 10f;
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
        Rigidbody _bullet = Instantiate(bullet, player.transform.position, Quaternion.identity);
        Vector3 v3Force = strength * transform.forward;
        _bullet.AddForce(v3Force);
        Destroy(_bullet, 5);

    }

}
