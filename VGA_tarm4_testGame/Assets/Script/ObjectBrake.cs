using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ObjectBrake : MonoBehaviour
{
    [SerializeField] bool m_kyeObje = false;
    [SerializeField] AudioClip m_keySEClip;
    [SerializeField] AudioClip m_brakeSEClip;
    AudioSource m_Audio;
    GameObject m_child;
    //GameObject go;
    // Start is called before the first frame update
    void Start()
    {   
        m_Audio = gameObject.GetComponent<AudioSource>();
        m_Audio.clip = m_keySEClip;
        m_child = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Atack")
        {
            AudioSource.PlayClipAtPoint(m_brakeSEClip,transform.position);
            DoreOpenController.JudgFunc(m_kyeObje);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown("f"))
            {
                m_Audio.Play();
            }
        }
    }
   
}
