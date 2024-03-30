// See https://aka.ms/new-console-template for more information

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        this.title = title;
        this.id = new Random().Next(10000, 99999);
        this.playCount = 0;
    }

    public int getPlayCount() { return playCount; }

    public string getTitle() { return title; }

    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine(this.id);
        Console.WriteLine(this.title);
        Console.WriteLine(this.playCount);
    }
}
public class SayaTubeUser
{
    private int i = 0;
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username;

    public SayaTubeUser(string username)
    {
        this.id = new Random().Next(10000, 99999);
        this.Username = username;
        this.uploadedVideos = [];
    }

    public int GetTotalVideoPlayCount()
    {
        int jumlah = 0;
        for (int i = 0; i < this.uploadedVideos.Count; i++)
        {
            jumlah += uploadedVideos[i].getPlayCount();
        }
        return jumlah;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        this.uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        int no = 1;
        Console.WriteLine("user : " + this.Username);
        for (int j = 0; j < this.uploadedVideos.Count; j++)
        {
            
            Console.WriteLine("Video " + no + " judul: " + this.uploadedVideos[j].getTitle());
            no++;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("adrian");
        SayaTubeVideo video1 = new SayaTubeVideo("Classroom Of the Elite");
        SayaTubeVideo video2 = new SayaTubeVideo("Boku No Pico");
        SayaTubeVideo video3 = new SayaTubeVideo("Ironman");
        SayaTubeVideo video4 = new SayaTubeVideo("Agak Laen");
        SayaTubeVideo video5 = new SayaTubeVideo("Indonesiaku");
        SayaTubeVideo video6 = new SayaTubeVideo("Social Page");
        SayaTubeVideo video7 = new SayaTubeVideo("Sword Art Online");
        SayaTubeVideo video8 = new SayaTubeVideo("Gak tau lagi saya");
        SayaTubeVideo video9 = new SayaTubeVideo("Death note");
        SayaTubeVideo video10 = new SayaTubeVideo("njay");

        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);

        user.PrintAllVideoPlaycount();
    }
}