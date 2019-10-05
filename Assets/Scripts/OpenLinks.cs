using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLinks : MonoBehaviour {

    ///
    /// PLAY SOUNDS FUNCTION
    ///
    public void playSound(string name)
    {
        FindObjectOfType<AudioController>().Play(name);
    }

    /// <summary>
    /// LINK FUNCTIONS BELOW
    /// </summary>
	public void PangeaInformation()
    {
		Application.OpenURL ("https://en.wikipedia.org/wiki/Pangaea");
	}

    public void HumanEvolutionaryTree()
    {
        Application.OpenURL("https://en.wikipedia.org/wiki/Timeline_of_human_evolution");
    }

    public void austrolopithecus()
    {
        Application.OpenURL("https://www.britannica.com/topic/Australopithecus");
    }

    public void homoHabilis()
    {
        Application.OpenURL("http://www.bradshawfoundation.com/origins/homo_habilis.php");
    }

    public void homoErectus()
    {
        Application.OpenURL("https://en.wikipedia.org/wiki/Homo_erectus");
    }

    public void brokenHillMan()
    {
        Application.OpenURL("https://en.wikipedia.org/wiki/Homo_erectus");
    }

    public void southAfricanDiscoveries()
    {
        Application.OpenURL("https://www.smithsonianmag.com/science-nature/top-7-human-evolution-discoveries-from-south-africa-158522696/");
    }

    public void topSevenTanzania()
    {
        Application.OpenURL("https://www.smithsonianmag.com/science-nature/the-top-seven-human-evolution-discoveries-from-tanzania-133532949/");
    }

    public void cave()
    {
        Application.OpenURL("https://history.howstuffworks.com/historical-figures/cave-dweller1.htm");
    }
    public void ironSmelting()
    {
        Application.OpenURL("https://en.wikipedia.org/wiki/Ancient_iron_production");
    }

    public void rockPaintings()
    {
        Application.OpenURL("https://en.wikipedia.org/wiki/Mwela_Rock_Paintings");
    }





}
