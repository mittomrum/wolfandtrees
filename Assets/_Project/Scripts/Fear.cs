using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Fear : MonoBehaviour
{
    private MeshRenderer m_Renderer;

    void Awake()
    {
        m_Renderer = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("TESt");
            Material material = m_Renderer.material;
            material.color = Color.red;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tree_OnFire"))
        {
            Material material = m_Renderer.material;
            material.color = Color.red;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        Material material = m_Renderer.material;
        material.color = Color.white;
    }
}