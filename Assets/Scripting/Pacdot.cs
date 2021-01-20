using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdot : MonoBehaviour
{
    public TMPro.TMP_Text scoreLbl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D co) {
        if (co.name == "Picture2_0") 
            scoreLbl.text = "3";
            Destroy(gameObject);
    }
}
