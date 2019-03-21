using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour
{

    public bool cantTouch = false;
   
    private float px = -0.5f;
    private float py = 0.15f;
    private float pz = -6.3f;
    private float rx = -54.5f;

    private GameController gameController;

    public int columnIndex;
    public int rowIndex;

    void Start()
    {
        gameController = GameObject.FindObjectOfType<GameController>();
    }
   
    void OnMouseDown()
    {
        gameController.Select(this);

    }

    public void SetPosition(int columnIndex, int rowIndex)
    {
        this.rowIndex = rowIndex;
        this.columnIndex = columnIndex;
        gameObject.transform.position =
            new Vector3(px + columnIndex * 0.25f, py + rowIndex * 0.275f, pz + rowIndex * 0.2f);
        gameObject.transform.eulerAngles = new Vector3(rx + rowIndex * 4.5f, 0, 0);

    }

    public void MoveDown()
    {
        SetPosition(columnIndex, rowIndex - 1);
    }
}