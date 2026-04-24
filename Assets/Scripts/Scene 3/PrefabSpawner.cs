using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public Object prefab;
    public int rows;
    public int columns;
    private int distance = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        for(int row = 0; row<rows; row++)
        {
            for(int column = 0; column<columns; column++)
            {
                Vector3 position = new Vector3(column*distance, 0, row*distance);

                Object.Instantiate(prefab, position, this.transform.rotation);
            }
        }
       
    }
}
