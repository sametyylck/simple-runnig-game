using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class gerisayım : MonoBehaviour
{
   [SerializeField]
   private GameObject gerisayımobje;
   [SerializeField]
   private Text gerisayımtext;

   GameManager gameManager;

   private void Awake() {
       gameManager=Object.FindObjectOfType<GameManager>();
   }

    void Start()
    {
       StartCoroutine(GerisayımRoutine());
    }

    IEnumerator GerisayımRoutine()
    {
        gerisayımtext.text="3";
        yield return new WaitForSeconds(0.3f);
        gerisayımobje.GetComponent<RectTransform>().DOScale(1,1f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(0.5f);
        gerisayımobje.GetComponent<RectTransform>().DOScale(0,1f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.3f);

        gerisayımtext.text="2";
        yield return new WaitForSeconds(0.3f);
        gerisayımobje.GetComponent<RectTransform>().DOScale(1,1f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(0.5f);
        gerisayımobje.GetComponent<RectTransform>().DOScale(0,1f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.3f);

        gerisayımtext.text="1";
        yield return new WaitForSeconds(0.3f);
        gerisayımobje.GetComponent<RectTransform>().DOScale(1,1f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(0.5f);
        gerisayımobje.GetComponent<RectTransform>().DOScale(0,1f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("SampleScene");

        StopAllCoroutines();
        

        
    }
    
    
}
