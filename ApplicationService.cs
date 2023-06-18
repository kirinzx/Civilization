using Newtonsoft.Json.Linq;

namespace Civilization; 

public class ApplicationService {
    public static JObject allCivsJson { get; set; }
    public const string ResxFile = "Resource1.resx";
    public static Icon icon { get; set; }
    public static Dictionary<string, string> playerCiv { get; set; }
    public static List<string> allCivsList { get; set; }
    
    public static List<T> getSampleFromList<T>(List<T> list, int aimNum) {
        T[] arr = list.ToArray();
        Random random = new Random();
        List<T> rdyList = new List<T>();
        while (rdyList.Count != aimNum) {
            T tmp = arr[random.Next(0, arr.Length)];
            if (!rdyList.Contains(tmp)) {
                rdyList.Add(tmp);
            }
        }
        return rdyList;
    }
}