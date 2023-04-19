using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class enemy_1_controller : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //rotate to look at the player
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.transform.position - transform.position), rotationSpeed * Time.deltaTime);


        //move towards the player
        transform.position += transform.forward * Time.deltaTime * moveSpeed;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            player.GetComponent<PlayerMovement>().TakeDamage();
        }
    }
}
