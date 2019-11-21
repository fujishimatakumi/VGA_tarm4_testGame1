using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoreOpenController : MonoBehaviour
{
    //float m_height;
    float m_width;
    //float m_positionX;
    float m_positionY;
    [SerializeField] static bool m_judgment = false;
    [SerializeField] float m_openSpead = 0.1f;
    GameObject ga;
    float m_downDistans;
    Vector3 m_nowPosition;
    // Start is called before the first frame update
    void Start()
    {   
        m_width = this.gameObject.transform.lossyScale.y;
        m_positionY = this.gameObject.transform.position.y;
        ga = this.gameObject;
        m_downDistans = m_positionY - m_width;
        m_nowPosition = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        if (m_judgment)
        {
            if (m_nowPosition.y > m_downDistans)
            {
                ga.gameObject.transform.Translate(0f,-m_openSpead, 0f);
                m_downDistans += m_openSpead;
            }
            else
            {
                m_judgment = false;
            }
        }
    }

    public static void JudgFunc(bool judg)
    {
        if (judg)
        {
            m_judgment = true;
        }
        else
        {
            m_judgment = false;
        }
    }
}