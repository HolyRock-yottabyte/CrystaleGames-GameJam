using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 2f;    // Takip H�z�

    
    public bool hasTarget = false;  // �lerlemek i�in hedef var m�
    
    public GameObject target;   // Kime yak�nla�s�n 

    private Rigidbody2D rb;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (hasTarget)
        {
            //Aradaki mesafeyi al
            float distance = Vector3.Distance(transform.position, target.transform.position);
            //2 birim mesafede miyim ?
            if (distance > 2)
            {
                //2 birim mesafe var
                follow(target.transform); //Takip et
            }
        }
    }

    // e�er bir �ey benimle �arp��maya ba�larsa bu y�ntemi uygulayaca��m
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("PlayerObject"))
        {    // is the other object the player
            target = collision.gameObject;      // di�er nesne oyuncu
            hasTarget = true;   // Hedef Var
        }
    }

    // bir �ey art�k benimle �arp��m�yorsa bu kodu �al��t�raca��m
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name.Equals("PlayerObject"))
        {
            target = null;
            hasTarget = false;
        }
    }

    private void follow(Transform target)
    {
        // beni hareket ettirmek i�in kat� bedenime g�� ekle
        rb.AddForce((target.transform.position - transform.position).normalized * speed);
    }
}
