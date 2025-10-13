using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GmaeDirector : MonoBehaviour
{
    public GameObject hpGage;

    public void DecreaseHP()
    {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
