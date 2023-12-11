using System.Reflection;

public class Vragenlijst : Onderzoek{
    private List<Vraag> Vragen = new List<Vraag>();
     
    public Vragenlijst(string titel, string? beschrijving, string? locatie, string? beloning, string status, Bedrijfsaccount bedrijfsaccount)
    {
        this.Titel = titel;
        this.Beschrijving = beschrijving;
        this.Locatie = locatie;
        this.Beloning = beloning;
        this.Status = status;
        this.OprichtingsDatum = setDateTimeNow();
        this.Created = setDateTimeNow();
        this.LastUpdated = setDateTimeNow();
        this.ID = GetNextID();
        this.Bedrijfsaccount = bedrijfsaccount;
    }
    private void VoegVraagToe(string text){
        Vraag vraag = new Vraag(text, this);
        Vragen.Add(vraag);
    }
}