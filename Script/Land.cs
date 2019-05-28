﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Land : MonoBehaviour
{
    private string uistr = "hello world";
    public Text nameLabel;
    private Vector3 screenPos;
    // Start is called before the first frame update
    void Start()
    {
        nameLabel.text = "HELLO";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
        namePos.z = 0;
        nameLabel.transform.position = namePos;
        
    }

    void OnMouseDown()
    {
        // 加入一个碰撞器之后才可以 BOX COLINDER 2D
        nameLabel.text = "";
        Destroy(this.gameObject);
        //gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    void OnGUI()
    {
        screenPos = Camera.main.WorldToScreenPoint(transform.position);
        // 这个地方可以设置文字出现的位置, 现在出现了遮挡
        GUI.Label(new Rect(screenPos.x, screenPos.y, 200, 20), uistr);
    }
}
