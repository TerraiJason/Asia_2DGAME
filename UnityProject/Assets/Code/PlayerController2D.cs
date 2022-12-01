using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [Header("Speed")]
    [SerializeField, Range(0, 10)]
    private float speedVertical = 3.5f;
    [SerializeField, Range(0, 10)]
    private float speedHorizontal = 4f;
    
    [Header("Picture")]
    [SerializeField]
    private Sprite pictureUp;
    [SerializeField]
    private Sprite pictureMiddle;
    [SerializeField]
    private Sprite pictureDown;

    [SerializeField, Header("PictureRenderFunction")]
    private SpriteRenderer spr;

    private void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        transform.Translate(speedHorizontal * Time.deltaTime * h, speedVertical * Time.deltaTime * v, 0);

        if (v > 0)
        {
            spr.sprite = pictureUp;
        }

        if (v < 0)
        {
            spr.sprite = pictureDown;
        }

        if(v == 0)
        {
            spr.sprite = pictureMiddle;
        }

    }

}
