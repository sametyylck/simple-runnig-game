using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
   
    public float horizalInput;
    public float speed=5f;
      public float speedf=5f;
    public float xRange=1.48f;
    public float forwad;
    private Oyuncukontrol oyuncukontrolscripts;
    public int puan=0;
    private GameObject puantext;
    public Text text,sontext;
    Transform muzzle;
    public bool bossft=false;
    public bool oyunbitti=false;
    public GameObject healt1,healt2,panel1;
    public GameObject panel,solyildiz,sagyildiz,ortayildiz;
   
    
    [SerializeField]
 
    
    void Start()
    {
        oyuncukontrolscripts=GameObject.Find("Oyuncu").GetComponent<Oyuncukontrol>();
      
        
          
    }

    // Update is called once per frame
    void Update()
    {
        
      if(oyunbitti==false){
        
         forwad=Input.GetAxis("Vertical");
         horizalInput=Input.GetAxis("Horizontal");
        if(transform.position.x<-xRange && bossft==false)
        {
                transform.position=new Vector3(-xRange,transform.position.y,transform.position.z);
        }
         if(transform.position.x>xRange && bossft==false)
        {
                transform.position=new Vector3(xRange,transform.position.y,transform.position.z);
        }
         if(transform.position.x<-8.75&& bossft==true)
        {
                transform.position=new Vector3(-xRange,transform.position.y,transform.position.z);
        }
         if(transform.position.x>8.75 && bossft==true)
        {
                transform.position=new Vector3(xRange,transform.position.y,transform.position.z);
        }
        
        
              
         if(oyuncukontrolscripts.gameover==false)
          {
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
             transform.Translate(Vector3.right*horizalInput*speedf*Time.deltaTime);
            }

          
         

            
          
        
      }
           
        
    }
    
    private void OnCollisionEnter(Collision other) {
        
          if(other.gameObject.CompareTag("yararlı"))
        {
            puan+=50;
            text.text= "Skor:"+puan.ToString();
            Destroy(other.gameObject);
            Debug.Log(puan);
            speed+=1f;
            speedf+=1f;
            
        }
          else if(other.gameObject.CompareTag("zararli"))
        {
            puan-=20;
            text.text="Skor:"+ puan.ToString();
            Destroy(other.gameObject);
            Debug.Log(puan);
            if(speed<2)
            {
              speed=1;
            }
            else{
                speed-=1.5f;
                speedf-=1.5f;
            }
            

        }
           else if(other.gameObject.CompareTag("bossft"))
        {
            oyuncukontrolscripts.animator.speed=0;
            oyuncukontrolscripts.animator.SetTrigger("dur");
            speed=0;
            bossft=true;
            
            savas();
        }
           else if(other.gameObject.CompareTag("iptal"))
        {
            oyuncukontrolscripts.isground=false;
            Destroy(other.gameObject);
            
            
        }
        
        
       
    }
   
    private void savas()
    {
        horizalInput=Input.GetAxis("Horizontal");  
        transform.Translate(Vector3.right*horizalInput*speedf*Time.deltaTime);
        oyuncukontrolscripts.animator.speed=1;
        healt1.SetActive(true);
        healt2.SetActive(true);
        panel1.SetActive(false);
        oyuncukontrolscripts.diry.Stop();
        
        

      
    }
    
}
 