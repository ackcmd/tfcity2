using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class NPC : MonoBehaviour {
    private const int statMax = 10;
    private const int skillMax = 501;

    public string npcName;
    public string npcDescription;
    public Sprite npcAvatar;
    private string[] opinions = { "hate", "unfriendly", "unfriendly", "cold", "cold", "neutral", "neutral", "friendly", "friendly", "friendly", "love" };
    private string[] ranks = { "slave", "freeman", "citizen", "noble", "legend" };

    //init_values
    public int opinion1; //opinion on player 0-statMax

    //base stats
    public int rank1;
    //0 - slave
    //1 - freeman
    //2 - citizen
    //3 - noble
    //4 - legend

    public int strenght1; //0-statMax
    public int dexterity1;//0-statMax
    public int constitution1;//0-statMax

    public int intellect1;//0-statMax
    public int arcane1;//0-statMax
    public int willpower1;//0-statMax

    //special stats
    public int dominance1;//0-skillMax
    public int obedience1;//0-skillMax

    //common skills
    public int housekeeping1;//0-skillMax
    public int cooking1;//0-skillMax
    public int nurse1;//0-skillMax
    public int secretary1;//0-skillMax
    public int alchemy1;//0-skillMax
    public int etiquette1;//0-skillMax
    public int martial1;//0-skillMax
    public int fitness1;//0-skillMax
    public int dance1;//0-skillMax
    public int singing1;//0-skillMax
    public int music1;//0-skillMax
    public int petplay1;//0-skillMax
    public int magic1;//0-skillMax
    public int mentor1;//0-skillMax
    //0-skillMax
    //sex skills

    public int handjob1;//0-skillMax
    public int footjob1;//0-skillMax
    public int titjob1;//0-skillMax
    public int rubbing1;//0-skillMax

    public int kissing1;//0-skillMax
    public int licking1;//0-skillMax
    public int blowjob1;//0-skillMax
    public int rimming1;//0-skillMax

    public int vaginal_r1;//0-skillMax
    public int anal_r1;//0-skillMax
    public int vaginal_g1;//0-skillMax
    public int anal_g1;//0-skillMax

    public int twosome1;//0-skillMax
    public int threesome1;//0-skillMax
    public int gangbang1;//0-skillMax
    public int bukkake1;//0-skillMax

    public int seduction1;//0-skillMax
    public int masturbation1;//0-skillMax
    public int selfhumiliation1;//0-skillMax

    public int bondage1;//0-skillMax
    public int domination1;//0-skillMax
    public int torture1;//0-skillMax

    public int selfbondage1;//0-skillMax
    public int submission1;//0-skillMax
    public int masochism1;//0-skillMax

    public int g_shower1;//0-skillMax
    public int scat1;//0-skillMax
    public int zoo1;//0-skillMax
    public int fisting1;//0-skillMax
    //init_values end

    //backing store begin -----------------------------------------------------

    private int opinion; //opinion on player 0-statMax

    //base stats
    private int rank;
    //0 - slave
    //1 - freeman
    //2 - citizen
    //3 - noble
    //4 - legend

    private int strenght; //0-statMax
    private int dexterity;//0-statMax
    private int constitution;//0-statMax

    private int intellect;//0-statMax
    private int arcane;//0-statMax
    private int willpower;//0-statMax

    //special stats
    private int dominance;//0-skillMax
    private int obedience;//0-skillMax

    //common skills
    private int housekeeping;//0-skillMax
    private int cooking;//0-skillMax
    private int nurse;//0-skillMax
    private int secretary;//0-skillMax
    private int alchemy;//0-skillMax
    private int etiquette;//0-skillMax
    private int martial;//0-skillMax
    private int fitness;//0-skillMax
    private int dance;//0-skillMax
    private int singing;//0-skillMax
    private int music;//0-skillMax
    private int petplay;//0-skillMax
    private int magic;//0-skillMax
    private int mentor;//0-skillMax
    //0-skillMax
    //sex skills

    private int handjob;//0-skillMax
    private int footjob;//0-skillMax
    private int titjob;//0-skillMax
    private int rubbing;//0-skillMax

    private int kissing;//0-skillMax
    private int licking;//0-skillMax
    private int blowjob;//0-skillMax
    private int rimming;//0-skillMax

    private int vaginal_r;//0-skillMax
    private int anal_r;//0-skillMax
    private int vaginal_g;//0-skillMax
    private int anal_g;//0-skillMax

    private int twosome;//0-skillMax
    private int threesome;//0-skillMax
    private int gangbang;//0-skillMax
    private int bukkake;//0-skillMax

    private int seduction;//0-skillMax
    private int masturbation;//0-skillMax
    private int selfhumiliation;//0-skillMax

    private int bondage;//0-skillMax
    private int domination;//0-skillMax
    private int torture;//0-skillMax

    private int selfbondage;//0-skillMax
    private int submission;//0-skillMax
    private int masochism;//0-skillMax

    private int g_shower;//0-skillMax
    private int scat;//0-skillMax
    private int zoo;//0-skillMax
    private int fisting;//0-skillMax
    //baking store end --------------------------------------------------

    public int Opinion
    {
        get
        {
            return (opinion);
        }

        set
        {
            if (value > 0 && value < statMax) opinion = value;
            if (value < 0) opinion = 0;
            if (value > statMax) opinion = statMax;
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
            if (value > 0 && value < statMax) strenght = value;
            if (value < 0) strenght = 0;
            if (value > statMax) strenght = statMax;
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
            if (value > 0 && value < statMax) dexterity = value;
            if (value < 0) dexterity = 0;
            if (value > statMax) dexterity = statMax;
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
            if (value > 0 && value < statMax) constitution = value;
            if (value < 0) constitution = 0;
            if (value > statMax) constitution = statMax;
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
            if (value > 0 && value < statMax) intellect = value;
            if (value < 0) intellect = 0;
            if (value > statMax) intellect = statMax;
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
            if (value > 0 && value < statMax) arcane = value;
            if (value < 0) arcane = 0;
            if (value > statMax) arcane = statMax;
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
            if (value > 0 && value < statMax) willpower = value;
            if (value < 0) willpower = 0;
            if (value > statMax) willpower = statMax;
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
            if (value > 0 && value < skillMax) dominance = value;
            if (value < 0) dominance = 0;
            if (value > skillMax) dominance = skillMax;
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
            if (value > 0 && value < skillMax) obedience = value;
            if (value < 0) obedience = 0;
            if (value > skillMax) obedience = skillMax;
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
            if (value > 0 && value < skillMax) housekeeping = value;
            if (value < 0) housekeeping = 0;
            if (value > skillMax) housekeeping = skillMax;
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
            if (value > 0 && value < skillMax) cooking = value;
            if (value < 0) cooking = 0;
            if (value > skillMax) cooking = skillMax;
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
            if (value > 0 && value < skillMax) nurse = value;
            if (value < 0) nurse = 0;
            if (value > skillMax) nurse = skillMax;
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
            if (value > 0 && value < skillMax) secretary = value;
            if (value < 0) secretary = 0;
            if (value > skillMax) secretary = skillMax;
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
            if (value > 0 && value < skillMax) alchemy = value;
            if (value < 0) alchemy = 0;
            if (value > skillMax) alchemy = skillMax;
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
            if (value > 0 && value < skillMax) etiquette = value;
            if (value < 0) etiquette = 0;
            if (value > skillMax) etiquette = skillMax;
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
            if (value > 0 && value < skillMax) martial = value;
            if (value < 0) martial = 0;
            if (value > skillMax) martial = skillMax;
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
            if (value > 0 && value < skillMax) fitness = value;
            if (value < 0) fitness = 0;
            if (value > skillMax) fitness = skillMax;
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
            if (value > 0 && value < skillMax) dance = value;
            if (value < 0) dance = 0;
            if (value > skillMax) dance = skillMax;
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
            if (value > 0 && value < skillMax) singing = value;
            if (value < 0) singing = 0;
            if (value > skillMax) singing = skillMax;
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
            if (value > 0 && value < skillMax) music = value;
            if (value < 0) music = 0;
            if (value > skillMax) music = skillMax;
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
            if (value > 0 && value < skillMax) petplay = value;
            if (value < 0) petplay = 0;
            if (value > skillMax) petplay = skillMax;
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
            if (value > 0 && value < skillMax) magic = value;
            if (value < 0) magic = 0;
            if (value > skillMax) magic = skillMax;
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
            if (value > 0 && value < skillMax) mentor = value;
            if (value < 0) mentor = 0;
            if (value > skillMax) mentor = skillMax;
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
            if (value > 0 && value < skillMax) handjob = value;
            if (value < 0) handjob = 0;
            if (value > skillMax) handjob = skillMax;
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
            if (value > 0 && value < skillMax) footjob = value;
            if (value < 0) footjob = 0;
            if (value > skillMax) footjob = skillMax;
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
            if (value > 0 && value < skillMax) titjob = value;
            if (value < 0) titjob = 0;
            if (value > skillMax) titjob = skillMax;
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
            if (value > 0 && value < skillMax) rubbing = value;
            if (value < 0) rubbing = 0;
            if (value > skillMax) rubbing = skillMax;
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
            if (value > 0 && value < skillMax) kissing = value;
            if (value < 0) kissing = 0;
            if (value > skillMax) kissing = skillMax;
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
            if (value > 0 && value < skillMax) licking = value;
            if (value < 0) licking = 0;
            if (value > skillMax) licking = skillMax;
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
            if (value > 0 && value < skillMax) blowjob = value;
            if (value < 0) blowjob = 0;
            if (value > skillMax) blowjob = skillMax;
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
            if (value > 0 && value < skillMax) rimming = value;
            if (value < 0) rimming = 0;
            if (value > skillMax) rimming = skillMax;
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
            if (value > 0 && value < skillMax) vaginal_r = value;
            if (value < 0) vaginal_r = 0;
            if (value > skillMax) vaginal_r = skillMax;
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
            if (value > 0 && value < skillMax) anal_r = value;
            if (value < 0) anal_r = 0;
            if (value > skillMax) anal_r = skillMax;
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
            if (value > 0 && value < skillMax) vaginal_g = value;
            if (value < 0) vaginal_g = 0;
            if (value > skillMax) vaginal_g = skillMax;
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
            if (value > 0 && value < skillMax) anal_g = value;
            if (value < 0) anal_g = 0;
            if (value > skillMax) anal_g = skillMax;
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
            if (value > 0 && value < skillMax) twosome = value;
            if (value < 0) twosome = 0;
            if (value > skillMax) twosome = skillMax;
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
            if (value > 0 && value < skillMax) threesome = value;
            if (value < 0) threesome = 0;
            if (value > skillMax) threesome = skillMax;
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
            if (value > 0 && value < skillMax) gangbang = value;
            if (value < 0) gangbang = 0;
            if (value > skillMax) gangbang = skillMax;
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
            if (value > 0 && value < skillMax) bukkake = value;
            if (value < 0) bukkake = 0;
            if (value > skillMax) bukkake = skillMax;
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
            if (value > 0 && value < skillMax) seduction = value;
            if (value < 0) seduction = 0;
            if (value > skillMax) seduction = skillMax;
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
            if (value > 0 && value < skillMax) masturbation = value;
            if (value < 0) masturbation = 0;
            if (value > skillMax) masturbation = skillMax;
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
            if (value > 0 && value < skillMax) selfhumiliation = value;
            if (value < 0) selfhumiliation = 0;
            if (value > skillMax) selfhumiliation = skillMax;
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
            if (value > 0 && value < skillMax) bondage = value;
            if (value < 0) bondage = 0;
            if (value > skillMax) bondage = skillMax;
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
            if (value > 0 && value < skillMax) domination = value;
            if (value < 0) domination = 0;
            if (value > skillMax) domination = skillMax;
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
            if (value > 0 && value < skillMax) torture = value;
            if (value < 0) torture = 0;
            if (value > skillMax) torture = skillMax;
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
            if (value > 0 && value < skillMax) selfbondage = value;
            if (value < 0) selfbondage = 0;
            if (value > skillMax) selfbondage = skillMax;
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
            if (value > 0 && value < skillMax) submission = value;
            if (value < 0) submission = 0;
            if (value > skillMax) submission = skillMax;
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
            if (value > 0 && value < skillMax) masochism = value;
            if (value < 0) masochism = 0;
            if (value > skillMax) masochism = skillMax;
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
            if (value > 0 && value < skillMax) g_shower = value;
            if (value < 0) g_shower = 0;
            if (value > skillMax) g_shower = skillMax;
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
            if (value > 0 && value < skillMax) scat = value;
            if (value < 0) scat = 0;
            if (value > skillMax) scat = skillMax;
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
            if (value > 0 && value < skillMax) zoo = value;
            if (value < 0) zoo = 0;
            if (value > skillMax) zoo = skillMax;
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
            if (value > 0 && value < skillMax) fisting = value;
            if (value < 0) fisting = 0;
            if (value > skillMax) fisting = skillMax;
        }
    }

    // Use this for initialization
    void Start()
    {
    }
        //this.transform.parent.GetComponent<BuildingManager>().defaultAction = StartDialogue;
    public void Init()
    { 
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
    void Update() {

    }

    public string GetOpinionString()
    {
        return (opinions[Opinion]);
    }

    public string GetBasicInfo()
    {
        string info = "";
        info += "Rank: " + ranks[Rank] + "\n";
        info += "Opinion on you: " + opinions[Opinion] + "\n";
        info += npcDescription;
        return (info);
    }

    public Dictionary<string, int> GetSexSkillsBasic()
    {
        Dictionary<string, int> skills = new Dictionary<string, int>();
        int tmp = Mathf.FloorToInt(Mathf.FloorToInt(Handjob / 100) + Mathf.FloorToInt(Footjob / 100) + Mathf.FloorToInt(Titjob / 100) + Mathf.FloorToInt(Rubbing / 100)) / 4;
        skills.Add("Stimulation", tmp);
        tmp = Mathf.FloorToInt(Mathf.FloorToInt(Kissing / 100) + Mathf.FloorToInt(Licking / 100) + Mathf.FloorToInt(Blowjob / 100) + Mathf.FloorToInt(Rimming / 100)) / 4;
        skills.Add("Oral", tmp);
        tmp = Mathf.FloorToInt(Mathf.FloorToInt(Anal_g / 100) + Mathf.FloorToInt(Anal_r / 100) + Mathf.FloorToInt(Vaginal_g / 100) + Mathf.FloorToInt(Vaginal_r / 100)) / 4;
        skills.Add("Sex", tmp);
        tmp = Mathf.FloorToInt(Mathf.FloorToInt(Twosome / 100) + Mathf.FloorToInt(Threesome / 100) + Mathf.FloorToInt(Gangbang / 100) + Mathf.FloorToInt(Bukkake / 100)) / 4;
        skills.Add("Group Sex", tmp);
        tmp = Mathf.FloorToInt(Mathf.FloorToInt(Seduction / 100) + Mathf.FloorToInt(Masturbation / 100) + Mathf.FloorToInt(Selfhumiliation / 100) ) / 3;
        skills.Add("Arousing", tmp);
        tmp = Mathf.FloorToInt(Mathf.FloorToInt(Bondage / 100) + Mathf.FloorToInt(Torture / 100) + Mathf.FloorToInt(Domination / 100)) / 3;
        skills.Add("Domination", tmp);
        tmp = Mathf.FloorToInt(Mathf.FloorToInt(Selfbondage / 100) + Mathf.FloorToInt(Masochism / 100) + Mathf.FloorToInt(Submission / 100)) / 3;
        skills.Add("Submission", tmp);
        tmp = Mathf.FloorToInt(Mathf.FloorToInt(G_shower / 100) + Mathf.FloorToInt(Scat / 100) + Mathf.FloorToInt(Zoo / 100) + Mathf.FloorToInt(Fisting / 100)) / 4;
        skills.Add("Extreme",tmp);
        return (skills);
    }

    public Dictionary<string, string> GetSexSkillsBasicTxt()
    {
        string level;
        Dictionary<string, string> skills = new Dictionary<string, string>();
        Dictionary<string, int> tmp = GetSexSkillsBasic();
        foreach (KeyValuePair<string, int> pair in tmp)
        {
            switch(pair.Value)
            {
                case 0:
                    level = "None";
                    break;
                case 1:
                    level = "Basic";
                    break;
                case 2:
                    level = "Advanced";
                    break;
                case 3:
                    level = "Professional";
                    break;
                case 4:
                    level = "Master";
                    break;
                case 5:
                    level = "ELITE";
                    break;
                default:
                    level = "---ERROR---";
                    break;
            }
            skills.Add(pair.Key, level);
        }
        return (skills);
    }
}
