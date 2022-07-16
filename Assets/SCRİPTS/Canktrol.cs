using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canktrol : MonoBehaviour
{
    public Health healt;
    public int currentHealth;
    public int can;
    private GameManager gameManager;
    private Rigidbody oyuncu;
     public Animator animator;
     private Boss boss;
     private Oyuncukontrol oyuncukontrolscripts;
    void Start()
    {
         gameManager=GameObject.Find("Oyuncu").GetComponent<GameManager>();
         oyuncukontrolscripts=GameObject.Find("Oyuncu").GetComponent<Oyuncukontrol>();
        oyuncu=GetComponent<Rigidbody>();
        currentHealth=can;
        healt.Maxcan(can);
        animator=GetComponent<Animator>();
        
    }

   
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider other)
     {
       if(other.gameObject.CompareTag("bosmermi")){
          TakeDamage(30);
          boss.animator.SetTrigger("hasar");
          
       }
         if(currentHealth==0){
            oyuncukontrolscripts.gameover=true;
            animator.SetBool("Death_b",true);
            animator.SetInteger("DeathType_int",1);
                 
             }
      
    }
    void TakeDamage(int damage){
         currentHealth-=damage;
         healt.Sethealt(currentHealth);
     }
 
}
