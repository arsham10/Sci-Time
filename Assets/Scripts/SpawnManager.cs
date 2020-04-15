using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject background_prefab;
    public Transform BgParent;
    private SpriteRenderer _spriteRenderer;
    public bool playerinrange = false;

    void Start()
    {
        //character = FindObjectOfType<player>();
        _spriteRenderer = background_prefab.GetComponent<SpriteRenderer>();
        Instantiate(background_prefab, BgParent);
        Debug.Log(_spriteRenderer.bounds.max);
        


    }
    //private void Update()
    //{
        
    //}

    public void SpawnBG() {
        Debug.Log("opsbhikvnsflkvnrt0gihqrgkovj");

        Instantiate(background_prefab, new Vector3(_spriteRenderer.bounds.max.x+1000, -19.57f, 0), transform.rotation, BgParent);
    }

}