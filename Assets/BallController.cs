using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    //得点を表示させるテキスト（課題用で追加）
    private GameObject scoreText;

    //得点
    int score = 0;

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        //シーン中のPointTextオブジェクトを取得（オブジェクトと繋げるイメージ？）
        this.scoreText= GameObject.Find("scoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            score += 5;

            this.scoreText.GetComponent<Text>().text = score + "point";

        }
        if(other.gameObject.tag == "LargeStarTag")
        {
            score += 10;

            this.scoreText.GetComponent<Text>().text = score + "point";
        }
        if(other.gameObject.tag == "SmallCloudTag")
        {
            score += 5;

            this.scoreText.GetComponent<Text>().text = score + "point";
        }
        if(other.gameObject.tag == "LargeCloudTag")
        {
            score += 10;

            this.scoreText.GetComponent<Text>().text = score + "point";
        }
    }
}