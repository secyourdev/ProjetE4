using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public bool goForwards = true;

    public bool horizontal = true;
    public float distanceToMove = 9f;
    public float duration = 1f;
    public bool isDoorOpened = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor() {
        StartCoroutine(OpenDoorCoroutine());
    }

    public IEnumerator OpenDoorCoroutine()
    {


        if (horizontal) {
            if (!isDoorOpened) {
                isDoorOpened = true;

                Vector3 targetPosition;
                // Calcule la position cible
                if (goForwards) {
                    targetPosition = transform.position + Vector3.left * distanceToMove;

                } else {
                    targetPosition = transform.position + Vector3.right * distanceToMove;

                }

                // Calcule la vitesse de déplacement en fonction de la durée
                float speed = distanceToMove / duration;

                // Déplace l'objet vers la position cible progressivement
                float elapsedTime = 0f;
                while (elapsedTime < duration)
                {
                    transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
                    elapsedTime += Time.deltaTime;
                    yield return null;
                }

                // Assurez-vous que la porte atteint exactement la position cible
                transform.position = targetPosition;

            }
        } else {
            if (!isDoorOpened) {
                isDoorOpened = true;

                Vector3 targetPosition;
                // Calcule la position cible
                if (goForwards) {
                    targetPosition = transform.position + Vector3.up * distanceToMove;

                } else {
                    targetPosition = transform.position + Vector3.down * distanceToMove;

                }

                // Calcule la vitesse de déplacement en fonction de la durée
                float speed = distanceToMove / duration;

                // Déplace l'objet vers la position cible progressivement
                float elapsedTime = 0f;
                while (elapsedTime < duration)
                {
                    transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
                    elapsedTime += Time.deltaTime;
                    yield return null;
                }

                // Assurez-vous que la porte atteint exactement la position cible
                transform.position = targetPosition;

            }
        }

        

        

    }
}
