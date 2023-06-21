using KGySoft.Resources;
using Newtonsoft.Json.Linq;

namespace Civilization; 

public class ApplicationService {
    public static JObject allCivsJson { get; set; }
    public static ResXResourceManager resourceManager = new ResXResourceManager("Resource1") { ResXResourcesDir = "" };
    public static Icon icon { get; set; }
    public static TableLayoutPanel playerCiv1 { get; set; }
    public static TableLayoutPanel playerCiv2 { get; set; }
    public static Label setting { get; set; }
    public static Label victory { get; set; }
    public static string gameMap { get; set; }
    public static Dictionary<Player, Civilization> playerCiv { get; set; }
    public static List<string> allCivsList { get; set; }

    public static List<T> getSampleFromList<T>(List<T> list, int aimNum) {
        T[] arr = list.ToArray();
        return getSample(arr, aimNum);
    }
    public static T[] getSampleFromArr<T>(T[] arr, int aimNum) {
        return getSample(arr, aimNum).ToArray();
    }

    private static List<T> getSample<T>(T[] arr, int aimNum) {
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

    public static void addPlayersToTables(List<Player> playersList, TableLayoutPanel playersTable1,TableLayoutPanel playersTable2) {
        int numOfPlayers = playersList.Count;
        int firstBunchFlag;
        int secondBunchFlag;
        if (numOfPlayers % 2 == 0) {
            firstBunchFlag = numOfPlayers / 2;
            secondBunchFlag = firstBunchFlag;
        }
        else {
            firstBunchFlag = numOfPlayers / 2 + 1;
            secondBunchFlag = numOfPlayers - (numOfPlayers / 2 + 1) + 1;
        }
        Player[] firstBunchPlayers = playersList.ToArray()[..firstBunchFlag];
        Player[] secondBunchPlayers = playersList.ToArray()[secondBunchFlag..];
        
        playersTable1.Controls.Clear();
        playersTable2.Controls.Clear();
        playersTable1.Controls.AddRange(firstBunchPlayers);
        playersTable2.Controls.AddRange(secondBunchPlayers);
    }
    public static void addPlayersToTables(List<TableLayoutPanel> panelsList, TableLayoutPanel playersTable1,TableLayoutPanel playersTable2) {
        int numOfPlayers = panelsList.Count;
        int firstBunchFlag;
        int secondBunchFlag;
        if (numOfPlayers % 2 == 0) {
            firstBunchFlag = numOfPlayers / 2;
            secondBunchFlag = firstBunchFlag;
        }
        else {
            firstBunchFlag = numOfPlayers / 2 + 1;
            secondBunchFlag = numOfPlayers - (numOfPlayers / 2 + 1) + 1;
        }
        TableLayoutPanel[] firstBunchPlayers = panelsList.ToArray()[..firstBunchFlag];
        TableLayoutPanel[] secondBunchPlayers = panelsList.ToArray()[secondBunchFlag..];
        
        playersTable1.Controls.Clear();
        playersTable2.Controls.Clear();
        playersTable1.Controls.AddRange(firstBunchPlayers);
        playersTable2.Controls.AddRange(secondBunchPlayers);
    }

    public static void openNewForm(Form newForm, Form currentForm) {
        newForm.Location = currentForm.Location;
        newForm.StartPosition = FormStartPosition.Manual;
        newForm.FormClosing += delegate { currentForm.Close(); };
        newForm.Text = currentForm.Text;
        newForm.Show();
        currentForm.Hide();
    }
}