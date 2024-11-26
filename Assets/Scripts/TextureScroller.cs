using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public Material material;
    public Vector2 direction;
    public float speed;

    void Update()
    {
        ScrollTexture();
    }
    
    void ScrollTexture()
    {
        material.mainTextureOffset += direction.normalized * speed * Time.deltaTime;
    }
}
