using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public bool canPickup = false;
    public int bookCount;
    public TextMeshProUGUI bookTrack;
    GameObject book;
    public GameObject roof;

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
        else if (other.CompareTag("Teleporters"))
        {
            if (bookCount == 5)
            {
                EndGame();
            }
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
        bookTrack.text = "Books: " + bookCount + "/5"; 
    }

    public void EndGame()
    {
        Destroy(roof);
        bookTrack.text = "Well done!";
    }
}
