using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    //(from move)
    [SerializeField] GameObject donut; //(also in sorting)
    //public static int disabledMove = 0;

    //(from sorting)
    GameObject SC;
    public Transform transformIndex;

    // Start is called before the first frame update
    void Start()
    {
        SC = GameObject.Find("Manager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Stage 1 gate (from move)
        if (other.tag == "Gate")
        {
            Click.allColours.Remove(donut.GetComponent<Click>().id); //these are the seleceted colours btw JESPER >.>
            Click.letThroughColours.Add(donut.GetComponent<Click>().id);
            Click.spawnedGO.Remove(donut); //These are ALSO the selected ones BTW >.>
            Click.letThroughGO.Add(donut);
            donut.SetActive(false);
            Move.disabledMove++;
        }

        //Stage 2 gate (from sorting)
        if (other.tag == "Stage2 Gate")
        {
            /*
            if (Click.letThroughGO.Count >= 1)
            {
                int index = System.Array.IndexOf(SC.GetComponent<Spawncolours>().stage2Spots, transformIndex);
                SC.GetComponent<Spawncolours>().availableSpots[index] = true;
                //SC.availableSpots[spotIndex] = true;
                SC.GetComponent<Spawncolours>().Stage2SpawnDots();
            }
            */
            Click.sortedColours.Add(Spawncolours.elapsedTime, donut.GetComponent<Click>().id);
            Click.letThroughColours.Remove(donut.GetComponent<Click>().id);
            Destroy(donut);
        }
    }

}
