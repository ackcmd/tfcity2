using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Hannah : NPC {

    RectTransform LocationWindow;
    RectTransform SecondaryText;
    GlobalVars globalvars;

    int StartDialogue()
    {
        int returnValue = 0;

        globalvars = FindObjectOfType<GlobalVars>();
        LocationWindow = globalvars.LocationWindow;
        SecondaryText = globalvars.SecondaryText;
        foreach (Transform child in SecondaryText)
        {
            switch (child.name)
            {
                case "Header":
                    child.GetComponent<Text>().text = npcName;
                    break;
                case "Text":
                    Text text = child.GetComponent<Text>();
                    text.text = GetBasicInfo();
                    break;
            }
        }

        return (returnValue);
    }


	// Use this for initialization
	void Start () {
        Opinion = opinion1; //opinion on player 0-10

        //base stats
        Rank = rank1;
        //0 - slave
        //1 - freeman
        //2 - citizen
        //3 - noble
        //4 - legend

        Strenght = strenght1; //0-10
        Dexterity = dexterity1;//0-10
        Constitution = constitution1;//0-10

        Intellect = intellect1;//0-10
        Arcane = arcane1;//0-10
        Willpower = willpower1;//0-10

        //special stats
        Dominance = dominance1;//0-100
        Obedience = obedience1;//0-100

        //common skills
        Housekeeping = housekeeping1;//0-100
        Cooking = cooking1;//0-100
        Nurse = nurse1;//0-100
        Secretary = secretary1;//0-100
        Alchemy = alchemy1;//0-100
        Etiquette = etiquette1;//0-100
        Martial = martial1;//0-100
        Fitness = fitness1;//0-100
        Dance = dance1;//0-100
        Singing = singing1;//0-100
        Music = music1;//0-100
        Petplay = petplay1;//0-100
        Magic = magic1;//0-100
        Mentor = mentor1;//0-100

        //sex skills

        Handjob = handjob1;//0-100
        Footjob = footjob1;//0-100
        Titjob = titjob1;//0-100
        Rubbing = rubbing1;//0-100

        Kissing = kissing1;//0-100
        Licking = licking1;//0-100
        Blowjob = blowjob1;//0-100
        Rimming = rimming1;//0-100

        Vaginal_r = vaginal_r1;//0-100
        Anal_r = anal_r1;//0-100
        Vaginal_g = vaginal_g1;//0-100
        Anal_g = anal_g1;//0-100

        Twosome = twosome1;//0-100
        Threesome = threesome1;//0-100
        Gangbang = gangbang1;//0-100
        Bukkake = bukkake1;//0-100

        Seduction = seduction1;//0-100
        Masturbation = masturbation1;//0-100
        Selfhumiliation = selfhumiliation1;//0-100

        Bondage = bondage1;//0-100
        Domination = domination1;//0-100
        Torture = torture1;//0-100

        Selfbondage = selfbondage1;//0-100
        Submission = submission1;//0-100
        Masochism = masochism1;//0-100

        G_shower = g_shower1;//0-100
        Scat = scat1;//0-100
        Zoo = zoo1;//0-100
        Fisting = fisting1;//0-100   

    }
	
	// Update is called once per frame
	void Update () {

    }
}
