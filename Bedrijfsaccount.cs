using System.ComponentModel.Design.Serialization;
using System.Data;

public class Bedrijfsaccount : Gebruiker
{
    private string? Functie {get; set;}
    private bool Beheerder {get; set;}
    private Bedrijf Bedrijf {get; set;}

    public Bedrijfsaccount(string voornaam, string achternaam, string postcode, string email, string? telefoonnummer, string rol, string functie, bool beheerder, Bedrijf bedrijf)
    {
        this.Voornaam = voornaam;
        this.Achternaam = achternaam;
        this.Postcode = postcode;
        this.Email = email;
        this.Telefoonnummer = telefoonnummer;
        this.Rol = rol;
        this.ID = GetNextID();
        this.Functie = functie;
        this.Beheerder = beheerder;
        this.Bedrijf = bedrijf;
        this.Created = setDateTimeNow();
        this.LastUpdate = setDateTimeNow();
    }
}   
