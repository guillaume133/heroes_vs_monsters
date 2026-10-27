
public class Adventurer : Entity
{

    // generate many Adventurer randomly.
    public static IEnumerable<Adventurer> getRandomAdventurers(int count)
    {
        for (int i = 0; i < count; i += 1)
        {
            int randomIndex = RandomManager.Next(3);
            switch (randomIndex)
            {
                case (0):
                    yield return new Knight();
                    break;
                case (1):
                    yield return new Mage();
                    break;
                case (2):
                    yield return new Rogue();
                    break;
            }
        }
    }


    // ---> bonus : names.

    private string _name;
    public string name
    {
        get { return this._name; }
    }

    public Adventurer()
    {
        this._name = namesPool[RandomManager.Next(namesPool.Length)];
        this._name = (  // format to PascalCase.
            this._name.Substring(0, 1).ToUpper() +
            this._name.Substring(1).ToLower()
        );
    }

    public override string ToString()
    {
        return this._name;
    }


    // list of medieval names.
    private static string[] namesPool = [
        "ADELINE",
        "ANNE",
        "BLANCHE",
        "CHARLES",
        "CONSTANCE",
        "EDWIN",
        "EMMA",
        "HUBERT",
        "JACQUES",
        "MATHILDE",
        "ADELAIDE",
        "ADÈLE",
        "ALIX",
        "ALPHONSE",
        "AMAURY",
        "ARMANDE",
        "ASTRID",
        "AUDE",
        "AUGUSTIN",
        "AURIANE",
        "AURORE",
        "BENEDICTE",
        "BERTHE",
        "BERTILLE",
        "CLOVIS",
        "COLLIN",
        "CONRAD",
        "EDOUARD",
        "HUGUES",
        "LAMBERT",
        "ADELBERT",
        "ALIENOR",
        "ANASTASIE",
        "ATHENAIS",
        "AUBRY",
        "CLOTAIRE",
        "HILDEGARDE",
        "LUBIN",
        "ADALBERT",
        "ADELIN",
        "ADON",
        "AELYS",
        "ALAIS",
        "BERENGER",
        "BONIFACE",
        "CLOUD",
        "CONAN",
        "DURAND",
        "FULBERT",
        "LANCELOT",
        "MESMIN",
        "RAINIER",
        "ADHEMAR",
        "AELIS",
        "AENOR",
        "AIRY",
        "ANACLET",
        "ANSBERT",
        "ARNOULD",
        "BERARD",
        "BRUNON",
        "CHILDEBERT",
        "CLODOMIR",
        "COLOMBAN",
        "FLEURET",
        "FORTUNAT",
        "GUENIEVRE",
        "GUILAUME",
        "HERIBERT",
        "HOEL",
        "ITHIER",
        "LANCELIN",
        "LOTHAIRE",
        "MAIEUL",
        "MARIC",
        "MATERNE",
        "MAUR",
        "ROMARY"
    ];

}