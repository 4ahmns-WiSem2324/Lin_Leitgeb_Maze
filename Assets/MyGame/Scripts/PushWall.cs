using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushWall : MonoBehaviour
{
    private Vector3 pos;
    public float speed;
    public float pullTime;
    public float activateTime;
    public bool activate;
    public bool start;

    private void Start()
    {
        pos = gameObject.transform.position; 
    }

    private void Update()
    {
        if(activate == true)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            StartCoroutine(Activation());
        }
        if(activate == false && start == true)
        {
            transform.Translate(Vector3.forward * -speed * Time.deltaTime);
        }
    }

    IEnumerator Activation()
    {
        yield return new WaitForSeconds(pullTime);
        activate = false;
        start = true;
        yield return new WaitForSeconds(activateTime);
        activate = true;
    }
}
