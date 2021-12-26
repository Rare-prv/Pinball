using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;

    //���_��\��������e�L�X�g�i�ۑ�p�Œǉ��j
    private GameObject scoreText;

    //���_
    int score = 0;

    // Use this for initialization
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");

        //�V�[������PointText�I�u�W�F�N�g���擾�i�I�u�W�F�N�g�ƌq����C���[�W�H�j
        this.scoreText= GameObject.Find("scoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
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