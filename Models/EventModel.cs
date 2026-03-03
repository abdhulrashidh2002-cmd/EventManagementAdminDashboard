using System.Text.Json.Serialization;

public class EventModel
{
 
    public string Title { get; set; }

   
    public string Category { get; set; }

 
    public int Capacity { get; set; }


    public DateTime Date { get; set; }


    public string Location { get; set; }

    public string Status { get; set; }

    public int Price {  get; set; }

    public string Description { get; set; }

 
    public string ImageUrl { get; set; }

 
    public string Id { get; set; }   // Firestore document ID
}