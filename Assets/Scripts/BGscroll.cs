//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BGscroll : MonoBehaviour
//{

//    public float scroll_speed = 0.1f;
//    private MeshRenderer mesh_render;


//    void Start()
//    {
//        mesh_render = GetComponent<MeshRenderer>();
//    }

   
//    void Update()
//    {
//        float x = Time.time * scroll_speed;

//        Vector2 offset = new Vector2(x, 0);

//        mesh_render.sharedMaterial.SetTextureOffset("_MainTex", offset);
//    }
//}
