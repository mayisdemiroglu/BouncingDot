using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{

    
    void Update()
    {
        StartCoroutine(Rotate());
    }

    IEnumerator Rotate()
    {
        //Fare konumunu alabilmemizi saðlayan kod 
        //Sadece X'in fare konumuna eriþiyorum
        Vector3 _mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, transform.position.y, transform.position.z));

        //Ýlk olarak bir 30 dönsün daha sonra tekrar bir 30 daha yaparak 60a tamamlýyoruz
        if (Input.GetMouseButtonDown(0) && _mousePos.x < 0)
        {
            transform.Rotate(0f, 0f, 30f);
            yield return new WaitForSeconds(0.1f);
            transform.Rotate(0f, 0f, 30f);
        }
        else if (Input.GetMouseButtonDown(0) && _mousePos.x > 0)
        {
            transform.Rotate(0f, 0f, -30f);
            yield return new WaitForSeconds(0.1f);
            transform.Rotate(0f, 0f, -30f);
        }
        yield return null;
    }
}
