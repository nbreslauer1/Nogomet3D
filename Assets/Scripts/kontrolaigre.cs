using UnityEngine;
using System.Collections;

public class kontrolaigre : MonoBehaviour
{
    public GameObject loptaPrefab;
    public float brzinaLopte;
    GameObject loptaInstance;
    Vector3 mousePocetak;
    Vector3 mouseKraj;

   float minPomak = 15f;
   float zDepth = 25f;
    //Use this for initialization
    void Start()
    {
        CreateLopta();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePocetak = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            mouseKraj = Input.mousePosition;
            if (Vector3.Distance(mouseKraj, mousePocetak) > minPomak)
            {
                //ubačaj lopte

                Vector3 hitPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDepth);

                hitPos = Camera.main.ScreenToWorldPoint(hitPos);
                loptaInstance.transform.LookAt(hitPos);
                loptaInstance.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * brzinaLopte, ForceMode.Impulse);
                Invoke("CreateLopta", 2f);
            }

        }
    }
    void CreateLopta()
    {
        loptaInstance = Instantiate (loptaPrefab, loptaPrefab.transform.position, Quaternion.identity) as GameObject;
    }
}