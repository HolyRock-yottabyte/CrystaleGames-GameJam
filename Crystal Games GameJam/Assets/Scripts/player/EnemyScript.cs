using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 2f;    // Takip Hýzý

    
    public bool hasTarget = false;  // Ýlerlemek için hedef var mý
    
    public GameObject target;   // Kime yakýnlaþsýn 

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

    // eðer bir þey benimle çarpýþmaya baþlarsa bu yöntemi uygulayacaðým
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("PlayerObject"))
        {    // is the other object the player
            target = collision.gameObject;      // diðer nesne oyuncu
            hasTarget = true;   // Hedef Var
        }
    }

    // bir þey artýk benimle çarpýþmýyorsa bu kodu çalýþtýracaðým
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
        // beni hareket ettirmek için katý bedenime güç ekle
        rb.AddForce((target.transform.position - transform.position).normalized * speed);
    }
}
