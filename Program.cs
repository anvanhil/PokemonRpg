
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using  TpPokemon;
internal class Program
{
    public static void Main(string[] args)

    {
        Console.WriteLine("Bienvenue dans le monde de Pokémon");
        Console.WriteLine("Choissisez un Starter");
        Console.WriteLine("1- Salamèche  2-Bulbizarre   3-Carapuce");

        var choixStarter = Console.ReadLine();



        switch (choixStarter)
        {
            case "1":
               
                Console.WriteLine("Vous avez choisis Salamèche");
                break;


            case "2":
                
                Console.WriteLine("Vous avez choisis Bulbizarre");
                break;



            case "3":
                
                Console.WriteLine("Vous avez choisis Carapuce");
                break;

        }
        Random random = new();
        Sauvage sauvage = new Sauvage();
        Starter starter = new Starter("Votre Pokémon");
        string retour = "non";
        while (retour != "oui")
        {
            Console.WriteLine("Que voulez vous faire?");
            Console.WriteLine("1-Partir à l'aventure  2-Voir les stats de votre pokémon  3-Quitter");
            var choixMenu = Console.ReadLine();

            switch (choixMenu)
            {
                case "1":
                    Console.WriteLine(sauvage.Name + " sauvage vous attaque");

                    while (starter.Health > 0 | sauvage.Health > 0)
                    {
                        Console.WriteLine("Que voulez vous faire ?");
                        Console.WriteLine("1- Attaquer   2-Se Soigner   3-Fuir");
                        int choixAction = int.Parse((Console.ReadLine()));
                        if (choixAction == 1)
                        {
                            if (starter.Speed >= starter.Speed)
                            {
                                sauvage.TakingDamage(starter.Damage);
                                Console.WriteLine("Vous avez infligé  " + starter.Damage + "DMG");
                                Console.WriteLine(sauvage.Name + "  " + sauvage.Health + " PV restants");
                                Console.WriteLine("ATTENTION!" + sauvage.Name + " attaque!");
                                starter.TakingDamage(sauvage.Damage);
                                Console.WriteLine(sauvage.Name + " avez infligé  " + sauvage.Damage + "DMG");
                                Console.WriteLine(starter.Name + "  " + starter.Health + " PV restants");
                            }
                            else
                            {
                                Console.WriteLine("ATTENTION!" + sauvage.Name + " attaque!");
                                starter.TakingDamage(sauvage.Damage);
                                Console.WriteLine(sauvage.Name + " avez infligé  " + sauvage.Damage + "DMG");
                                Console.WriteLine(starter.Name + "  " + starter.Health + " PV restants");
                                sauvage.TakingDamage(starter.Damage);
                                Console.WriteLine("Vous avez infligé  " + starter.Damage + "DMG");
                                Console.WriteLine(sauvage.Name + "  " + sauvage.Health + " PV restants");
                            }
                        }
                        if (choixAction == 2)
                        {
                            Console.WriteLine("Vous utilisez une potion");
                            starter.Potion(20);
                            Console.WriteLine("Vous avez " + starter.Health + " HP");
                            Console.WriteLine("ATTENTION!" + sauvage.Name + " attaque!");
                            starter.TakingDamage(sauvage.Damage);
                            Console.WriteLine(sauvage.Name + " avez infligé  " + sauvage.Damage + "DMG");
                            Console.WriteLine(starter.Name + "  " + starter.Health + " PV restants");
                        }

                        if (choixAction == 3)
                        {
                            if (random.Next(0, 50) < 10)
                            {
                                Console.WriteLine("Vous n'avez pas réussi à vous échapper");
                                Console.WriteLine("ATTENTION!" + sauvage.Name + " attaque!");
                                starter.TakingDamage(sauvage.Damage);
                                Console.WriteLine(sauvage.Name + " avez infligé  " + sauvage.Damage + "DMG");
                                Console.WriteLine(starter.Name + "  " + starter.Health + " PV restants");
                            }
                            else
                            {
                                Console.WriteLine("vous avez réussi à vous échapper");
                                break;
                            }
                        }
                        if (starter.Health <= 0)
                        {
                            Console.WriteLine("Vous avez péri");
                            retour = "oui";
                            break;
                        }
                        if (sauvage.Health <= 0)
                        {
                            Console.WriteLine("Vous avez gagné votre combat");
                            starter.Level += 1;
                            break;
                        }
                    }
                    break;
                case "2":
                        Console.WriteLine("Point de vie = " + starter.Health);
                        Console.WriteLine("Dégats = " + starter.Damage);
                        Console.WriteLine("Vitesse = " + starter.Speed);
                        Console.WriteLine("Defense = " + starter.Defense);
                        Console.WriteLine("Level = " + starter.Level);
                        Console.WriteLine("");
                        break;
                case "3":
                    Console.WriteLine("A bientot pour de nouvelles aventures");
                    retour = "oui";
                    break;
            }

        }
    }
}


