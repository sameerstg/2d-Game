using UnityEngine;
using UnityEngine.UI;

public class LeftMoveButton : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Button leftMoveButton;

    void Start()
    {
        leftMoveButton.onClick.AddListener(MoveLeft);
    }

    void MoveLeft()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
