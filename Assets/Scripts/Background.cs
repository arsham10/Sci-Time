using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private SpawnManager _spawner;


    private void Start()
    {
        _spawner = FindObjectOfType<SpawnManager>();
    }
    private void Update()
    {
        _spawner = FindObjectOfType<SpawnManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            //_spawner.SpawnBG();
            Debug.Log("helloooooooooooooo");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //_spawner.playerinrange = true;
        _spawner.SpawnBG();

    }


}