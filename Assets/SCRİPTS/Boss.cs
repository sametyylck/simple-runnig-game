using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    private Rigidbody boss;
    public  bool gameover;
    public Animator animator;
    public int can=100;
     public GameObject prefabmermi;
     public Transform muzzle;
     public int currentHealth;
     private Oyuncukontrol oyuncukontrol;
     
     public float speed;
     public Transform[] movepoints;
     private int randompos;
      private GameManager gameManager;
      public Health healt;
      public bool son=true;
    
    int i =0;
    int targetFrame;
    void Start()
    {
       
        oyuncukontrol=GameObject.FindWithTag("Oyuncu").GetComponent<Oyuncukontrol>();
        boss=GetComponent<Rigidbody>();
        animator=GetComponent<Animator>();
      targetFrame = Random.Range(100,200);
       randompos=Random.Range(0,movepoints.Length);
       gameManager=GameObject.Find("Oyuncu").GetComponent<GameManager>();
       currentHealth=can;
       healt.Maxcan(can);
       
       

    }
    

    void Update()
    {
          
         transform.position=Vector3.MoveTowards(
            transform.position,

            movepoints[randompos].position,
            speed*Time.deltaTime
        );
        
        if(gameManager.bossft==true)
        {
             i++;
            if(i==targetFrame && son==true){

            Instantiate(prefabmermi,muzzle.position,prefabmermi.transform.rotation);
            i = 0;
            targetFrame = Random.Range(50,500);
            animator.SetTrigger("savas");
            
        }
        }
       
        if(Vector3.Distance(transform.position,movepoints[randompos].position)<0.2f){
            randompos=Random.Range(0,movepoints.Length);
        
    }
        
    }
     private void OnTriggerEnter(Collider other) {
         if(other.gameObject.CompareTag("dur"))
         {
             animator.SetTrigger("savas");
             
         }
         if(other.gameObject.CompareTag("playermermi"))
         {
             TakeDamage(10);

                if(currentHealth<30)
                {
                    animator.SetTrigger("vur");
                    speed=0;
                    son=false;
                 }
                 if(currentHealth<0)
                    {
                        animator.SetTrigger("olum");
                        speed=0;
                        son=false;
                        gameManager.oyunbitti=true;
                        oyuncukontrol.panel1.GetComponent<RectTransform>().DOScale(1f,2f).SetEase(Ease.Flash);
                        gameManager.sontext.text=gameManager.puan.ToString();
                        if(gameManager.puan<400)
                        {
                            gameManager.solyildiz.SetActive(true);
                        }
                        else if(400<gameManager.puan && gameManager.puan<800)
                        {
                            gameManager.solyildiz.SetActive(true);
                            gameManager.ortayildiz.SetActive(true);
                        }
                        else if(800<gameManager.puan )
                        {
                            gameManager.solyildiz.SetActive(true);
                            gameManager.ortayildiz.SetActive(true);
                            gameManager.sagyildiz.SetActive(true);
                            
                        }
                        
                        
                        
                 
                    }
             
         }
         
         
         
         
     }
     
     

     void TakeDamage(int damage){
         currentHealth-=damage;
         healt.Sethealt(currentHealth);
     }
    }

