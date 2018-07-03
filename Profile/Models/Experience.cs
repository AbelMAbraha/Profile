using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Profile.Models
{
    public class Experience
    {
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Tasks { get; set; }

        public static List<Experience> Exp()
        {
            List<Experience> ExperienceList = new List<Experience>();
            ExperienceList.Add(new Experience { CompanyName = "Coder Dojo (LIA 1)", Date = "26 Sept, 2016 — 9 Dec, 2016", Tasks = "Utveckling av ett webbaserat medlemsregister i ASP.NET MVC med C#, SQL, HTML, JavaScript / jQuery, CSS & Bootstrap.Webbapplikation riktade sig till att föreningen(Coder Dojo) skulle användas för att registrera nya medlemmar samt administrera existerande medlemmar.", Title = "Frontend Utvecklare" });
            ExperienceList.Add(new Experience { CompanyName = "Coder Dojo (LIA 2)", Date = "20 Mars, 2017 — 6 Juni, 2017", Tasks = "Fortsatte med samma projekt som jag har beskrivit ovanför, men mer fokus på Backend delen och tog över projektledar-rollen.", Title = "Backend Utvecklare/Projektledare" });
            ExperienceList.Add(new Experience { CompanyName = "PostNord AB", Date = "8 Nov, 2017 - Nu", Tasks = "Paketsortering, avgång (fylla på lastbilar med paket), lossning.", Title = "Terminalarbetare" });
            ExperienceList.Add(new Experience { CompanyName = "They Care Hammarbygården AB", Date = "Okt, 2014 — Aug, 2015", Tasks = "Serverat mat, städat, gett medicin och hållt dom sällskap.", Title = "Personal" });
            ExperienceList.Add(new Experience { CompanyName = "Willy's", Date = "Nov, 2011 — Feb, 2012", Tasks = "Varuplockning och påfyllning av hyllor och kylar med mejeri osv.", Title = "Praktik" });
            ExperienceList.Add(new Experience { CompanyName = "Kista Bibliotek", Date = "Feb, 2010 — April, 2010", Tasks = "Organisera böcker i hyllor efter bokstavsordning samt genre. Hjälpa besökare med datorer, lämna tillbaka böcker, skicka brev(ifall dom har lånat för länge), samt att lokalisera böcker.", Title = "Praktik" });
            ExperienceList.Add(new Experience { CompanyName = "Stockholms Län Landsting (Sommarjobb)", Date = "Juni, 2010 — Juli, 2010", Tasks = "Hålla rent genom att rengöra golv, fönster, dörrar m.m stärkte mitt sinne för att arbeta hårt, arbeta med ett team, vara noggrann och metodiskt.", Title = "Lokalvårdare" });
            ExperienceList.Add(new Experience { CompanyName = "Lidl", Date = "Okt, 2009 — Dec, 2009", Tasks = "Varuplockning, Bemöta kunder, Påfyllning och Kassa.", Title = "Praktik" });
            ExperienceList.Add(new Experience { CompanyName = "Ica", Date = "Feb, 2008 — Mars, 2008", Tasks = "Hur man jobbar i ett lager, påfyllning av varor i hyllor, stärkt kvalitetsmedvetenhet och vanan av arbete med färskvaror.", Title = "Praktik" });
            return ExperienceList;
        }
    }
}