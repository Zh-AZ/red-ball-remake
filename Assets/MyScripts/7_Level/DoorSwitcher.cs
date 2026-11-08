using UnityEngine;
using System.Collections;

public class DoorSwitcher : MonoBehaviour
{
    [SerializeField] protected GameObject door_1;
    [SerializeField] protected GameObject door_2;
    [SerializeField] protected GameObject door_3;

    private Vector3 firstDoorStartPosition = new Vector3(12.5059996f, 1.9697268f, 37.0195274f);
    private Vector3 secondDoorStartPosition = new Vector3(-11.9029999f, 8.62012005f, 37.0195313f);
    private Vector3 thirdDoorStartPosition = new Vector3(1.5f, 15.9200001f, 47.6809998f);

    private Vector3 firstDoorEndPosition = new Vector3(12.5059996f, 3.97900009f, 37.0195274f);
    private Vector3 secondDoorEndPosition = new Vector3(-11.9029999f, 10.6490002f, 37.0195313f);
    private Vector3 thirdDoorEndPosition = new Vector3(1.5f, 17.823f, 47.6809998f);

    protected IEnumerator OpenDoor_1()
    {
        door_1.transform.position = Vector3.MoveTowards(door_1.transform.position, GetPosition(door_1, firstDoorEndPosition), 2f * Time.deltaTime);
        door_2.transform.position = Vector3.MoveTowards(door_2.transform.position, GetPosition(door_2, secondDoorStartPosition), 2f * Time.deltaTime);
        door_3.transform.position = Vector3.MoveTowards(door_3.transform.position, GetPosition(door_3, thirdDoorStartPosition), 2f * Time.deltaTime);

        yield return new WaitForSeconds(1f);
    }

    protected IEnumerator OpenDoor_2()
    {
        door_2.transform.position = Vector3.MoveTowards(door_2.transform.position, GetPosition(door_2, secondDoorEndPosition), 2f * Time.deltaTime);
        door_1.transform.position = Vector3.MoveTowards(door_1.transform.position, GetPosition(door_1, firstDoorStartPosition), 2f * Time.deltaTime);
        door_3.transform.position = Vector3.MoveTowards(door_3.transform.position, GetPosition(door_3, thirdDoorStartPosition), 2f * Time.deltaTime);

        yield return new WaitForSeconds(1f);
    }

    protected IEnumerator OpenDoor_3()
    {
        door_3.transform.position = Vector3.MoveTowards(door_3.transform.position, GetPosition(door_3, thirdDoorEndPosition), 2f * Time.deltaTime);
        door_1.transform.position = Vector3.MoveTowards(door_1.transform.position, GetPosition(door_1, firstDoorStartPosition), 2f * Time.deltaTime);
        door_2.transform.position = Vector3.MoveTowards(door_2.transform.position, GetPosition(door_2, secondDoorStartPosition), 2f * Time.deltaTime);

        yield return new WaitForSeconds(1f);
    }

    protected Vector3 GetPosition(GameObject door, Vector3 targetPosition)
    {
        Vector3 pos = door.transform.position;
        pos.y = Mathf.MoveTowards(pos.y, targetPosition.y, 2f * Time.deltaTime);

        return door.transform.position = pos;
    }
}

// Door 1 start position Vector3(12.5059996,1.9697268,37.0195274)
// Door 1 end position Vector3(12.5059996,3.97900009,37.0195274)

// Door 2 start position Vector3(-11.9029999,8.62012005,37.0195313)
// Door 2 end position Vector3(-11.9029999,10.6490002,37.0195313)

// Door 3 start position Vector3(1.5,15.9200001,47.6809998)
// Door 3 end position Vector3(1.5,17.823,47.6809998)
