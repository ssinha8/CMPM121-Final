using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool canPickup = false;
    public int bookCount;
    GameObject book;

    void Start()
    {
        bookCount = 0;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickups"))
        {
            canPickup = true;
            book = other.gameObject;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pickups"))
        {
            canPickup = false;
        }
    }
    void Update()
    {
        if (canPickup == true && Input.GetKeyDown(KeyCode.E))
        {
            GrabBook();
        }
    }

    public void GrabBook()
    {
        bookCount += 1;
        Destroy(book);
        canPickup = false;
    }
}
