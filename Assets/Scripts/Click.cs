using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{

    [SerializeField] GameObject point;
    public Vector2 id;
    //public static Dictionary<Vector2, float> allColours = new Dictionary<Vector2, float>();
    public static Dictionary<(float, Vector2), Vector2> chosenColours = new Dictionary<(float, Vector2), Vector2>();
    public static Dictionary<float, Vector2> sortedColours = new Dictionary<float, Vector2>();
    
    public static List<Vector3> letThroughColours = new List<Vector3>();
    public static List<Vector3> allColours = new List<Vector3>();

    public static List<GameObject> letThroughGO = new List<GameObject>();
    public static List<GameObject> spawnedGO = new List<GameObject>();


    public static int disabledClick = 0;

    [SerializeField] GameObject arrows;

    private void OnMouseDown()
    {
        //if (!chosenColours.ContainsKey(point.GetComponent<Click>().id))
        //{
        //}

        //chosenColours.Add((Spawncolours.elapsedTime, point.transform.position), point.GetComponent<Click>().id);
        //allColours.Remove(point.GetComponent<Click>().id);

        if (Spawncolours.stage2 == false)
        {
            if (!UI.gamePaused)
            {
                GameObject arrow = Instantiate(arrows, new Vector2(Random.Range(6f, 8f), Random.Range(3.5f, 3.7f)), Quaternion.Euler(0, 0, 110));
                arrow.GetComponent<Arrow>().donutTarget = point;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
