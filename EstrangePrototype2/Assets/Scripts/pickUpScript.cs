using UnityEngine;
using System.Collections;

public class pickUpScript : MonoBehaviour {

    public int picturePieces = 0;

    RaycastHit hit;

    public GameObject[] picturePiece;

    public AudioClip paperCrumble;

    AudioSource source;

	// Use this for initialization
	void Start () {
        Instantiate(picturePiece[0], new Vector3(0f, 1f, 0f), Quaternion.identity);
        Instantiate(picturePiece[1], new Vector3(3f, 1f, 0f), Quaternion.identity);
        Instantiate(picturePiece[2], new Vector3(-3f, 1f, 0f), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        Ray pickUp = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 50f);

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E geklikt");
            if (Physics.Raycast(pickUp, out hit, 20f))
            {
                Debug.Log("ray");
                if (hit.collider.gameObject.CompareTag("PictureOne"))
                {
                    Debug.Log("pic1");
                    hit.collider.gameObject.SetActive(false);
                    GetComponent<AudioSource>().PlayOneShot(paperCrumble, 1f);
                    picturePieces = picturePieces + 1;
                }
                if (hit.collider.gameObject.CompareTag("PictureTwo"))
                {
                    Debug.Log("pic2");
                    GetComponent<AudioSource>().PlayOneShot(paperCrumble, 1f);
                    hit.collider.gameObject.SetActive(false);
                    picturePieces = picturePieces + 1;
                }
                if (hit.collider.gameObject.CompareTag("PictureThree"))
                {
                    Debug.Log("pic3");
                    GetComponent<AudioSource>().PlayOneShot(paperCrumble, 1f);
                    hit.collider.gameObject.SetActive(false);
                    picturePieces = picturePieces + 1;
                }
            }
        }
    }
}
