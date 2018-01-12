using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Shader m_cubeShader;
    private Material m_cubeMaterial;
    private Renderer m_cubeRenderer;

    void Start()
    {
        m_cubeShader = GetComponent<Shader>();
        m_cubeMaterial = GetComponent<Material>();
        m_cubeRenderer = GetComponent<Renderer>();

        m_cubeRenderer.material.shader = Shader.Find("Standard");

        //OKOK   m_cubeRenderer.material.SetColor("_Color", Color.red);

        //m_cubeMaterial.SetColor("_Color", Color.green);

        // Material material = new Material(Shader.Find("Transparent/Diffuse"));
        // material.color = Color.green;
        // GetComponent<Renderer>().material = material;
    }

    void Update()
    {
        m_cubeRenderer.material.SetColor("_Color", Color.Lerp(Color.Lerp(Color.green, Color.blue, Mathf.Sin(1-Time.time)), Color.red, Mathf.Cos(Time.time)));
       // m_cubeRenderer.material.SetColor("_Color", Color.Lerp(Color.blue, Color.red, Mathf.PingPong(Time.time, 1)));
    }
}
