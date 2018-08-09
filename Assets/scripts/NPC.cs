using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class NPC : MonoBehaviour {

    public string npcName;
    public string npcDescription;
    public Sprite npcAvatar;
    private string[] opinions = { "hate", "unfriendly", "unfriendly", "cold", "cold", "neutral", "neutral", "friendly", "friendly", "friendly", "love" };
    private string[] ranks = { "slave", "freeman", "citizen", "noble", "legend" };

    //init_values
    public int opinion1; //opinion on player 0-10

    //base stats
    public int rank1;
    //0 - slave
    //1 - freeman
    //2 - citizen
    //3 - noble
    //4 - legend

    public int strenght1; //0-10
    public int dexterity1;//0-10
    public int constitution1;//0-10

    public int intellect1;//0-10
    public int arcane1;//0-10
    public int willpower1;//0-10

    //special stats
    public int dominance1;//0-100
    public int obedience1;//0-100

    //common skills
    public int housekeeping1;//0-100
    public int cooking1;//0-100
    public int nurse1;//0-100
    public int secretary1;//0-100
    public int alchemy1;//0-100
    public int etiquette1;//0-100
    public int martial1;//0-100
    public int fitness1;//0-100
    public int dance1;//0-100
    public int singing1;//0-100
    public int music1;//0-100
    public int petplay1;//0-100
    public int magic1;//0-100
    public int mentor1;//0-100
    //0-100
    //sex skills

    public int handjob1;//0-100
    public int footjob1;//0-100
    public int titjob1;//0-100
    public int rubbing1;//0-100

    public int kissing1;//0-100
    public int licking1;//0-100
    public int blowjob1;//0-100
    public int rimming1;//0-100

    public int vaginal_r1;//0-100
    public int anal_r1;//0-100
    public int vaginal_g1;//0-100
    public int anal_g1;//0-100

    public int twosome1;//0-100
    public int threesome1;//0-100
    public int gangbang1;//0-100
    public int bukkake1;//0-100

    public int seduction1;//0-100
    public int masturbation1;//0-100
    public int selfhumiliation1;//0-100

    public int bondage1;//0-100
    public int domination1;//0-100
    public int torture1;//0-100

    public int selfbondage1;//0-100
    public int submission1;//0-100
    public int masochism1;//0-100

    public int g_shower1;//0-100
    public int scat1;//0-100
    public int zoo1;//0-100
    public int fisting1;//0-100
    //init_values end

    //backing store begin -----------------------------------------------------

    private int opinion; //opinion on player 0-10

    //base stats
    private int rank; 
    //0 - slave
    //1 - freeman
    //2 - citizen
    //3 - noble
    //4 - legend

    private int strenght; //0-10
    private int dexterity;//0-10
    private int constitution;//0-10

    private int intellect;//0-10
    private int arcane;//0-10
    private int willpower;//0-10

    //special stats
    private int dominance;//0-100
    private int obedience;//0-100

    //common skills
    private int housekeeping;//0-100
    private int cooking;//0-100
    private int nurse;//0-100
    private int secretary;//0-100
    private int alchemy;//0-100
    private int etiquette;//0-100
    private int martial;//0-100
    private int fitness;//0-100
    private int dance;//0-100
    private int singing;//0-100
    private int music;//0-100
    private int petplay;//0-100
    private int magic;//0-100
    private int mentor;//0-100
    //0-100
    //sex skills

    private int handjob;//0-100
    private int footjob;//0-100
    private int titjob;//0-100
    private int rubbing;//0-100

    private int kissing;//0-100
    private int licking;//0-100
    private int blowjob;//0-100
    private int rimming;//0-100

    private int vaginal_r;//0-100
    private int anal_r;//0-100
    private int vaginal_g;//0-100
    private int anal_g;//0-100

    private int twosome;//0-100
    private int threesome;//0-100
    private int gangbang;//0-100
    private int bukkake;//0-100

    private int seduction;//0-100
    private int masturbation;//0-100
    private int selfhumiliation;//0-100

    private int bondage;//0-100
    private int domination;//0-100
    private int torture;//0-100

    private int selfbondage;//0-100
    private int submission;//0-100
    private int masochism;//0-100

    private int g_shower;//0-100
    private int scat;//0-100
    private int zoo;//0-100
    private int fisting;//0-100
    //baking store end --------------------------------------------------

    public int Opinion
    {
        get
        {
            return (opinion);
        }

        set
        {
            if (value > 0 && value<10) opinion = value;
            if (value < 0) opinion = 0;
            if (value > 10) opinion = 10;
        }
    }

    //base stats

    //------------
    public int Rank
    {
        get
        {
            return (rank);
        }

        set
        {
            //if (rank != 0) // once a slave, always a slave
            //{
                if (value > 0 && value < 4) rank = value;
                if (value < 0) rank = 0;
                if (value > 4) rank = 4;
            //}
        }
    }
    //-----------
    public int Strenght
    {
        get
        {
            return (strenght);
        }

        set
        {
            if (value > 0 && value < 10) strenght = value;
            if (value < 0) strenght = 0;
            if (value > 10) strenght = 10;
        }
    }
    //----------------
    public int Dexterity
    {
        get
        {
            return (dexterity);
        }

        set
        {
            if (value > 0 && value < 10) dexterity = value;
            if (value < 0) dexterity = 0;
            if (value > 10) dexterity = 10;
        }
    }
    //---------------
    public int Constitution
    {
        get
        {
            return (constitution);
        }

        set
        {
            if (value > 0 && value < 10) constitution = value;
            if (value < 0) constitution = 0;
            if (value > 10) constitution = 10;
        }
    }
    //-----------------
    public int Intellect
    {
        get
        {
            return (intellect);
        }

        set
        {
            if (value > 0 && value < 10) intellect = value;
            if (value < 0) intellect = 0;
            if (value > 10) intellect = 10;
        }
    }
    //----------------
    public int Arcane
    {
        get
        {
            return (arcane);
        }

        set
        {
            if (value > 0 && value < 10) arcane = value;
            if (value < 0) arcane = 0;
            if (value > 10) arcane = 10;
        }
    }
    //-------------------
    public int Willpower
    {
        get
        {
            return (willpower);
        }

        set
        {
            if (value > 0 && value < 10) willpower = value;
            if (value < 0) willpower = 0;
            if (value > 10) willpower = 10;
        }
    }

    //special stats
    public int Dominance
    {
        get
        {
            return (dominance);
        }

        set
        {
            if (value > 0 && value < 100) dominance = value;
            if (value < 0) dominance = 0;
            if (value > 100) dominance = 100;
        }
    }
    //----------------
    public int Obedience
    {
        get
        {
            return (obedience);
        }

        set
        {
            if (value > 0 && value < 100) obedience = value;
            if (value < 0) obedience = 0;
            if (value > 100) obedience = 100;
        }
    }

    //common skills
    public int Housekeeping
    {
        get
        {
            return (housekeeping);
        }

        set
        {
            if (value > 0 && value < 100) housekeeping = value;
            if (value < 0) housekeeping = 0;
            if (value > 100) housekeeping = 100;
        }
    }
    //--------------------
    public int Cooking
    {
        get
        {
            return (cooking);
        }

        set
        {
            if (value > 0 && value < 100) cooking = value;
            if (value < 0) cooking = 0;
            if (value > 100) cooking = 100;
        }
    }
    //---------------------

    public int Nurse
    {
        get
        {
            return (nurse);
        }

        set
        {
            if (value > 0 && value < 100) nurse = value;
            if (value < 0) nurse = 0;
            if (value > 100) nurse = 100;
        }
    }
    //---------------------
    public int Secretary
    {
        get
        {
            return (secretary);
        }

        set
        {
            if (value > 0 && value < 100) secretary = value;
            if (value < 0) secretary = 0;
            if (value > 100) secretary = 100;
        }
    }
    //---------------------
    public int Alchemy
    {
        get
        {
            return (alchemy);
        }

        set
        {
            if (value > 0 && value < 100) alchemy = value;
            if (value < 0) alchemy = 0;
            if (value > 100) alchemy = 100;
        }
    }
    //----------------------
    public int Etiquette
    {
        get
        {
            return (etiquette);
        }

        set
        {
            if (value > 0 && value < 100) etiquette = value;
            if (value < 0) etiquette = 0;
            if (value > 100) etiquette = 100;
        }
    }
    //------------------------
    public int Martial
    {
        get
        {
            return (martial);
        }

        set
        {
            if (value > 0 && value < 100) martial = value;
            if (value < 0) martial = 0;
            if (value > 100) martial = 100;
        }
    }
    //-----------------------
    public int Fitness
    {
        get
        {
            return (fitness);
        }

        set
        {
            if (value > 0 && value < 100) fitness = value;
            if (value < 0) fitness = 0;
            if (value > 100) fitness = 100;
        }
    }
    //----------------
    public int Dance
    {
        get
        {
            return (dance);
        }

        set
        {
            if (value > 0 && value < 100) dance = value;
            if (value < 0) dance = 0;
            if (value > 100) dance = 100;
        }
    }
    //------------------
    public int Singing
    {
        get
        {
            return (singing);
        }

        set
        {
            if (value > 0 && value < 100) singing = value;
            if (value < 0) singing = 0;
            if (value > 100) singing = 100;
        }
    }
    //----------
    public int Music
    {
        get
        {
            return (music);
        }

        set
        {
            if (value > 0 && value < 100) music = value;
            if (value < 0) music = 0;
            if (value > 100) music = 100;
        }
    }
    //--------------
    public int Petplay
    {
        get
        {
            return (petplay);
        }

        set
        {
            if (value > 0 && value < 100) petplay = value;
            if (value < 0) petplay = 0;
            if (value > 100) petplay = 100;
        }
    }
    //---------------
    public int Magic
    {
        get
        {
            return (magic);
        }

        set
        {
            if (value > 0 && value < 100) magic = value;
            if (value < 0) magic = 0;
            if (value > 100) magic = 100;
        }
    }
    //--------------------
    public int Mentor
    {
        get
        {
            return (mentor);
        }

        set
        {
            if (value > 0 && value < 100) mentor = value;
            if (value < 0) mentor = 0;
            if (value > 100) mentor = 100;
        }
    }

    //sex skills

    public int Handjob
    {
        get
        {
            return (handjob);
        }

        set
        {
            if (value > 0 && value < 100) handjob = value;
            if (value < 0) handjob = 0;
            if (value > 100) handjob = 100;
        }
    }
    //---------------
    public int Footjob
    {
        get
        {
            return (footjob);
        }

        set
        {
            if (value > 0 && value < 100) footjob = value;
            if (value < 0) footjob = 0;
            if (value > 100) footjob = 100;
        }
    }
    //-------------
    public int Titjob
    {
        get
        {
            return (titjob);
        }

        set
        {
            if (value > 0 && value < 100) titjob = value;
            if (value < 0) titjob = 0;
            if (value > 100) titjob = 100;
        }
    }
    //----------------
    public int Rubbing
    {
        get
        {
            return (rubbing);
        }

        set
        {
            if (value > 0 && value < 100) rubbing = value;
            if (value < 0) rubbing = 0;
            if (value > 100) rubbing = 100;
        }
    }
    //---------------

    public int Kissing
    {
        get
        {
            return (kissing);
        }

        set
        {
            if (value > 0 && value < 100) kissing = value;
            if (value < 0) kissing = 0;
            if (value > 100) kissing = 100;
        }
    }
    //-------------
    public int Licking
    {
        get
        {
            return (licking);
        }

        set
        {
            if (value > 0 && value < 100) licking = value;
            if (value < 0) licking = 0;
            if (value > 100) licking = 100;
        }
    }
    //-----------
    public int Blowjob
    {
        get
        {
            return (blowjob);
        }

        set
        {
            if (value > 0 && value < 100) blowjob = value;
            if (value < 0) blowjob = 0;
            if (value > 100) blowjob = 100;
        }
    }
    //------------
    public int Rimming
    {
        get
        {
            return (rimming);
        }

        set
        {
            if (value > 0 && value < 100) rimming = value;
            if (value < 0) rimming = 0;
            if (value > 100) rimming = 100;
        }
    }
    //-------------------

    public int Vaginal_r
    {
        get
        {
            return (vaginal_r);
        }

        set
        {
            if (value > 0 && value < 100) vaginal_r = value;
            if (value < 0) vaginal_r = 0;
            if (value > 100) vaginal_r = 100;
        }
    }
    //----------------
    public int Anal_r
    {
        get
        {
            return (anal_r);
        }

        set
        {
            if (value > 0 && value < 100) anal_r = value;
            if (value < 0) anal_r = 0;
            if (value > 100) anal_r = 100;
        }
    }
    //-----------
    public int Vaginal_g
    {
        get
        {
            return (vaginal_g);
        }

        set
        {
            if (value > 0 && value < 100) vaginal_g = value;
            if (value < 0) vaginal_g = 0;
            if (value > 100) vaginal_g = 100;
        }
    }
    //---------------
    public int Anal_g
    {
        get
        {
            return (anal_g);
        }

        set
        {
            if (value > 0 && value < 100) anal_g = value;
            if (value < 0) anal_g = 0;
            if (value > 100) anal_g = 100;
        }
    }
    //----------------

    public int Twosome
    {
        get
        {
            return (twosome);
        }

        set
        {
            if (value > 0 && value < 100) twosome = value;
            if (value < 0) twosome = 0;
            if (value > 100) twosome = 100;
        }
    }
    //---------------
    public int Threesome
    {
        get
        {
            return (threesome);
        }

        set
        {
            if (value > 0 && value < 100) threesome = value;
            if (value < 0) threesome = 0;
            if (value > 100) threesome = 100;
        }
    }
    //-------------
    public int Gangbang
    {
        get
        {
            return (gangbang);
        }

        set
        {
            if (value > 0 && value < 100) gangbang = value;
            if (value < 0) gangbang = 0;
            if (value > 100) gangbang = 100;
        }
    }
    //-----------
    public int Bukkake
    {
        get
        {
            return (bukkake);
        }

        set
        {
            if (value > 0 && value < 100) bukkake = value;
            if (value < 0) bukkake = 0;
            if (value > 100) bukkake = 100;
        }
    }
    //------------

    public int Seduction
    {
        get
        {
            return (seduction);
        }

        set
        {
            if (value > 0 && value < 100) seduction = value;
            if (value < 0) seduction = 0;
            if (value > 100) seduction = 100;
        }
    }
    //-------------
    public int Masturbation
    {
        get
        {
            return (masturbation);
        }

        set
        {
            if (value > 0 && value < 100) masturbation = value;
            if (value < 0) masturbation = 0;
            if (value > 100) masturbation = 100;
        }
    }
    //-------------
    public int Selfhumiliation
    {
        get
        {
            return (selfhumiliation);
        }

        set
        {
            if (value > 0 && value < 100) selfhumiliation = value;
            if (value < 0) selfhumiliation = 0;
            if (value > 100) selfhumiliation = 100;
        }
    }
    //-------------

    public int Bondage
    {
        get
        {
            return (bondage);
        }

        set
        {
            if (value > 0 && value < 100) bondage = value;
            if (value < 0) bondage = 0;
            if (value > 100) bondage = 100;
        }
    }
    //------------
    public int Domination
    {
        get
        {
            return (domination);
        }

        set
        {
            if (value > 0 && value < 100) domination = value;
            if (value < 0) domination = 0;
            if (value > 100) domination = 100;
        }
    }
    //-----------
    public int Torture
    {
        get
        {
            return (torture);
        }

        set
        {
            if (value > 0 && value < 100) torture = value;
            if (value < 0) torture = 0;
            if (value > 100) torture = 100;
        }
    }
    //------------

    public int Selfbondage
    {
        get
        {
            return (selfbondage);
        }

        set
        {
            if (value > 0 && value < 100) selfbondage = value;
            if (value < 0) selfbondage = 0;
            if (value > 100) selfbondage = 100;
        }
    }
    //----------
    public int Submission
    {
        get
        {
            return (submission);
        }

        set
        {
            if (value > 0 && value < 100) submission = value;
            if (value < 0) submission = 0;
            if (value > 100) submission = 100;
        }
    }
    //---------------
    public int Masochism
    {
        get
        {
            return (masochism);
        }

        set
        {
            if (value > 0 && value < 100) masochism = value;
            if (value < 0) masochism = 0;
            if (value > 100) masochism = 100;
        }
    }
    //-------------------

    public int G_shower
    {
        get
        {
            return (g_shower);
        }

        set
        {
            if (value > 0 && value < 100) g_shower = value;
            if (value < 0) g_shower = 0;
            if (value > 100) g_shower = 100;
        }
    }
    //-------------
    public int Scat
    {
        get
        {
            return (scat);
        }

        set
        {
            if (value > 0 && value < 100) scat = value;
            if (value < 0) scat = 0;
            if (value > 100) scat = 100;
        }
    }
    //----------
    public int Zoo
    {
        get
        {
            return (zoo);
        }

        set
        {
            if (value > 0 && value < 100) zoo = value;
            if (value < 0) zoo = 0;
            if (value > 100) zoo = 100;
        }
    }
    //--------------
    public int Fisting
    {
        get
        {
            return (fisting);
        }

        set
        {
            if (value > 0 && value < 100) fisting = value;
            if (value < 0) fisting = 0;
            if (value > 100) fisting = 100;
        }
    }

    // Use this for initialization
    void Start ()
    {


}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string GetOpinionString()
    {
        return (opinions[Opinion]);
    }

    public string GetBasicInfo()
    {
        string info = "";
        info += "Rank: " + ranks[Rank] +"\n";
        info += "Opinion on you: " + opinions[Opinion] + "\n";
        info += npcDescription;
        return (info);
    }

}
