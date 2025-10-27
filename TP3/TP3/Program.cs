using TP3;


class Program
{
    public static void Main()
    {
        // Pour lire le .csv
        List<person> listePerson = [];
        using (StreamReader sr = new StreamReader(@"C:\C#\TP3\TP3\CoursSupDeVinci_C#.csv"))
        {
            string line;
            bool firstLine = true; // Pour ignorer l’en-tête

            while ((line = sr.ReadLine()) != null)
            {
                if (firstLine) // Ignore la première ligne d'en-têtes.
                {
                    firstLine = false;
                    continue;
                }

                string[] values = line.Split(','); // le séparateur peut changer selon le fichier.

                // Récupérér les valeurs pour chaque personne dans .csv
                person personne = new person();
                personne.Lastname = values[1];
                personne.Firstname = values[2];
                String dateAnniv = values[3];
                String addresse = values[4];
                personne.Taille = int.Parse(values[5]);

                // Pour découper l'adresse
                List<String> listAddress = addresse.Split(';').ToList();

                personne.AdressDetails = new Details(listAddress[0], int.Parse(listAddress[1]), listAddress[2]);

                DateTime.TryParse(dateAnniv, out DateTime birth);
                DateTime ajd = DateTime.Today;

                int age = DateTime.Now.Year - birth.Year;

                // si mois de naissance est après le mois d'aujourdhui
                if (ajd.Month < birth.Month ||
                    //  ou si dans le même mois, mais que le jour est apres aujourd'hui
                    (ajd.Month == birth.Month && ajd.Day < birth.Day))
                {
                    age = age - 1;
                }

                personne.Birthdate = age;

                // On ajoute les personnes a la listePerson, fondamentale pour la suite
                listePerson.Add(personne);




            }
        }

        // Exercice 2
        
        // foreach (person personne in listePerson)
        //  {
        //  //     Console.WriteLine(
        //  //         $"Tu es {personne.Firstname} {personne.Lastname}, tu as {personne.Birthdate} ans, tu habites au {personne.AdressDetails.Street} à {personne.AdressDetails.City} {personne.AdressDetails.Postalcode} et tu mesures {personne.Taille} cm");
        //  // }

        //Exercice 3 
        
        // calculer la moyenne
        int moyenne = (int)listePerson.Average(p => p.Taille);
        // nombre de personne plus grand que la moyenne des taille
        int plusgrands = listePerson.Count(p => p.Taille > moyenne);
        // pour arrondir correctement 
        float taillemoyennmetre = moyenne / 100f;
        // Console.WriteLine(
        //     $"Il y a {plusgrands} personnes qui sont plus grandes que la moyenne de la classe qui est de {taillemoyennmetre} m.");

        // Exercice 3.5: 
        
        Classe maClasse = new Classe();
        maClasse.Eleves = listePerson;

        
        // Console.WriteLine("Quelle est le nom de la classe ?");
        // maClasse.Name = Console.ReadLine();
        // Console.WriteLine("Quelle est le niveau de la classe?");
        // maClasse.Level = Console.ReadLine();
        // Console.WriteLine("Quelle est le nom de l'école ?");
        // maClasse.School = Console.ReadLine();
        
        
        // Console.WriteLine($"Voici la liste des élèves de la classe de {maClasse.Name} de {maClasse.School}");
        // foreach (person personne in listePerson)
        // {
        //     Console.WriteLine($"{personne.Lastname} {personne.Firstname}");
        // }

        
        
        
        // Avoir les éleves les plus grands venant de Nantes qui ont une taille plus grande que la taille moyenne de la classe. 
        // Le tout dans l'ordre décroissant
         
       List<person> grands = maClasse.Eleves.Where(person => person.Taille > moyenne && person.AdressDetails.City == "Nantes").
           OrderByDescending(person => person.Taille).ToList();
        
       Console.WriteLine("Élèves plus grands que la taille moyenne de la classe:");
       
       // Utile pour l'affichage en forme de classement. 
       int compteur = 1;
       
       // Boucle pour parcourir tous les plus grands que la moyenne (en taille) et les afficher. 
       foreach (person personne in grands)
       {
           // 100f : pour mettre au bon format
           // F2 : Pour avoir le 0 dans les nombres derrière la virgule
           Console.WriteLine($" {compteur} - {personne.Firstname}: {(personne.Taille/100f):F2} m");
           // Incrémenter le compteur à chaque ajout d'un élève pour avoir l'affichage en forme de classement. 
           compteur++;
       }
    }
}

