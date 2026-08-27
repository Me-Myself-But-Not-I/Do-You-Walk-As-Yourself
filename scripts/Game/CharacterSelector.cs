using System.Globalization;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class CharacterSelector : MonoBehaviour
{
    public Details details;
    public Speach speaker;
    public float chance;
    public float fchance;
    public int character;
    public bool fae;
    public bool walker;
    private float number;
    public bool shot;
    public bool documented;
    public bool released;
    private bool correct;
    public bool decided;
    public int person;
    public GameObject[] Characters;

    void Start()
    {
        select();
    }

    public void select()
    {
        if (!speaker.gameOver)
        {
            number = Random.Range(1f, 100f);
            chance = (details.day - 2) * 5;
            fchance = (details.day - 1) * 2;
            if (number < chance)
            {
                walker = true;
                fae = false;
            }
            else if (number < chance + fchance)
            {
                fae = true;
                walker = false;
            }
            else
            {
                walker = false;
                fae = false;
            }

            chooseCharacter();
        }
    }
    
    public void gun()
    {
        shot = true;
        if (walker == true)
        {
            correct = true;
            details.found[character] = true;
            details.noFound += 1;
            decided = true;
        }
        else
        {
            correct = false;
            decided = true;
        }

        endPerson();
    }

    public void pencil()
    {
        documented = true;
        if (fae == true)
        {
            correct = true;
            decided = true;
        }
        else
        {
            correct = false;
            decided = true;
        }
        endPerson();
    }

    public void release()
    {
        decided = true;
        if (fae == true)
        {
            correct = false;
        }
        else if (walker == true)
        {
            correct = false;
        }
        else
        {
            correct = true;
        }
        endPerson();
    }

    public void chooseCharacter()
    {
        if (details.noFound < 11)
        {
            if (fae && !walker)
            {
                character = Random.Range(0, 3);
            }
            else if (walker && !fae)
            {
                character = Random.Range(0, 11);
            }
            else if (!walker && !fae)
            {
                character = Random.Range(0, 11);
            }

            if (details.found[character])
            {
                chooseCharacter();
            }
            else if (character <4)
            {
                if (!walker && details.faePerson[character])
                {
                    fae = true;
                }
            }
            speaker.speak();
            for (int i = 0; i < Characters.Length; i++)
            {
                Characters[i].SetActive(i == character);
            }
        }
        else
        {
            speaker.gameWon();
        }
    }

    public void endPerson()
    {
        if (decided == true && correct == true)
        {
            if (person < 3)
            {
                select();
                person += 1;
            }
            else if(true)
            {
                details.day += 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else
        {
            speaker.gameLost();
        }
    }
}
