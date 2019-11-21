using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBrake : MonoBehaviour
{
    [SerializeField] bool m_kyeObje = false;
    GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        go = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Atack")
        {
            DoreOpenController.JudgFunc(m_kyeObje);
            Destroy(go);
        }
    }

   /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Atack")
        {
            Destroy(go);
        }
    }
    */
}
