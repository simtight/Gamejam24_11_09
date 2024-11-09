using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;

    [SerializeField] Sprite back_girl;
    [SerializeField] Sprite ago_girl;

    private SpriteRenderer SpriteRenderer;

    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        y = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
        
        ImageChange();

        transform.position = new Vector3(Mathf.Clamp(this.transform.position.x + x, -8.86f, 8.86f),
        Mathf.Clamp(this.transform.position.y + y, -4.48f, 4.48f), 0);
    }


    public void ImageChange()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            SpriteRenderer.sprite = back_girl;
        }
        else if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            SpriteRenderer.sprite = ago_girl;
        }
    }
}
