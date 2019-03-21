using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    public static int score = 0;

    public bool playAudio = true;

    public GameObject gameOver;
   
    public GameObject container;
  
    public GameObject pauseA;
    public GameObject playA;

    public GameObject whiteBlock;
    public GameObject blackBlock;


    private ArrayList blocks;

    private void StartGame()
    {

        gameOver.SetActive(false);

        blocks = new ArrayList();
        for (int rowIndex = 0; rowIndex < 6; rowIndex++)
        {
            AddBlock(rowIndex);
        }
    }
   
    void AddBlock(int rowIndex)
    {

        int columnIndex = Random.Range(0, 5);

        for (int i = 0; i != 5; ++i)
        {
            GameObject o;
            if (i == columnIndex)
            {
                o = Instantiate(blackBlock) as GameObject;
            }
            else
            {
                o = Instantiate(whiteBlock) as GameObject;
            }
            o.transform.parent = container.transform;
            Block b = o.GetComponent<Block>();
            b.SetPosition(i, rowIndex);
            blocks.Add(b);
        }
    }
   
    public void Select(Block block)
    {
        if (playAudio)
        {
            GetComponent<AudioSource>().Play();
        }

        if (block.rowIndex == 0)
        {

            if (block.cantTouch)
            {
                score += 1;
                for (int i = 0; i < blocks.Count; i++)
                {
                    Block b = (Block)blocks[i];
                    b.MoveDown();

                    if (b.rowIndex == -1)
                    {
                        blocks.RemoveAt(i);
                        Destroy(b.gameObject);
                        i--;
                    }
                }

                AddBlock(5);
            }
            else
            {
                gameOver.SetActive(true);
              
            }
        }
      
       // ShowScore();
    }

    void Clean()
    {
        for (int i = 0; i < blocks.Count; i++)
        {
            Block b = (Block)blocks[i];
            blocks.RemoveAt(i);
            Destroy(b.gameObject);
            i--;
        }
        score = 0;
    }
   
    void PlayAudio()
    {
        playAudio = false;
        pauseA.SetActive(false);
        playA.SetActive(true);
    }
    //关闭音乐
    void shutAudio()
    {
        playAudio = true;
        pauseA.SetActive(true);
        playA.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }


}