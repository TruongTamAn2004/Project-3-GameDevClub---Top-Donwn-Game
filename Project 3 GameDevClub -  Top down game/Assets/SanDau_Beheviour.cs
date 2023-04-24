using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanDau_Beheviour : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<Rigidbody2D>().gravityScale = 9;
            collision.GetComponent<SpriteRenderer>().sortingOrder -= 1;
        }
    }
}
