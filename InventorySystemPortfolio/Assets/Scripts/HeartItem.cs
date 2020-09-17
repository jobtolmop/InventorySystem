using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class HeartItem : MonoBehaviour
{
    public GameObject effect;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        Instantiate(effect, player.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
