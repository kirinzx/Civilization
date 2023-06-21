namespace Civilization; 

public class CivilizationUnit {
    public string generalName { get; }
    public string name { get; }
    public Image image { get; }
    public Dictionary<string,string> info { get; }
    public CivilizationUnit(string generalName,string name,string image,Dictionary<string,string> info) {
        this.generalName = generalName;
        this.name = name;
        this.image = (Image)ApplicationService.resourceManager.GetObject(image.Split("/")[1].Split(".")[0]);
        this.info = info;
    }
}