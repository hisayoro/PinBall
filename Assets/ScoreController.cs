using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //ポイントを表示するテキスト
    private GameObject ScoreText;
    private int score = 0;

    //衝突時に呼ばれる関数。とりあえず、対象物に関わらず+10としておく
    void OnCollisionEnter(Collision collision)
    {
        //SmallStarに衝突したら+10点
        if (collision.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
        }

        //LargeStarに衝突したら+50点
        if (collision.gameObject.tag == "LargeStarTag")
        {
            this.score += 50;
        }

        //SmallCloudに衝突したら30点
        if (collision.gameObject.tag == "SmallCloudTag")
        {
            this.score += 30;
        }
        //LargeStarに衝突したら+100点
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
        
        //ScoreTextにscoreを表示
        this.ScoreText.GetComponent<Text>().text = score.ToString() + "点";

    }       

}
