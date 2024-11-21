using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : SoundCoin
{
    [SerializeField]
    private GameObject rock;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject rock = PoolObject.instance.GetFreeElement();

            if (rock != null)
            {
                rock.transform.position = new Vector3(0, 6);
                rock.transform.rotation = transform.rotation;                        /*Спавн монет и вызов метода звука*/
                rock.SetActive(true);
            }

            PlaySound(coinAudioSource[0]);
        }
    }
}
