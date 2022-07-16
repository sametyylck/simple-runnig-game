using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class menusaayım : MonoBehaviour
{
     [SerializeField]
   private GameObject gerisayımobje;
   [SerializeField]
   private Text gerisayımtext;
    private void Awake() {
       gameManager=Object.FindObjectOfType<GameManager>();
   }

   GameManager gameManager;
    void Start()
    {
        StartCoroutine(GerisayımRoutine());
    }

    // Update is called once per frame
   IEnumerator GerisayımRoutine()
    {
        gerisayımtext.text="Basla";
        yield return new WaitForSeconds(0.7f);
        gerisayımobje.GetComponent<RectTransform>().DOScale(1,1f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(0.7f);
        gerisayımobje.GetComponent<RectTransform>().DOScale(0,1f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.7f);

        StopAllCoroutines();
        

        
    }
    
}
