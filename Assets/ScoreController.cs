using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //�|�C���g��\������e�L�X�g
    private GameObject ScoreText;
    private int score = 0;

    //�Փˎ��ɌĂ΂��֐��B�Ƃ肠�����A�Ώە��Ɋւ�炸+10�Ƃ��Ă���
    void OnCollisionEnter(Collision collision)
    {
        //SmallStar�ɏՓ˂�����+10�_
        if (collision.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
        }

        //LargeStar�ɏՓ˂�����+50�_
        if (collision.gameObject.tag == "LargeStarTag")
        {
            this.score += 50;
        }

        //SmallCloud�ɏՓ˂�����30�_
        if (collision.gameObject.tag == "SmallCloudTag")
        {
            this.score += 30;
        }
        //LargeStar�ɏՓ˂�����+100�_
        if (collision.gameObject.tag == "LargeCloudTag")
        {
            this.score += 100;
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        this.ScoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        
        //ScoreText��score��\��
        this.ScoreText.GetComponent<Text>().text = score.ToString() + "�_";

    }       

}
