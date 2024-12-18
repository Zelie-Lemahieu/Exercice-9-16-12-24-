using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialisation des valeurs :
            int entreeUtilisateur = 0;
            List<int> listeDesNotes = new List<int>();
            int plusGrandeNote = 0;
            int plusPetiteNote = 20;
            double moyenneDesNotes = 0;

            do
            {   //MENU PRINCIPAL :
                Console.Write("--- Gestion des notes avec menu ---\n" +
                    "\n1----Saisir les notes" +
                    "\n2----La plus grande note" +
                    "\n3----La plus petite note" +
                    "\n4----La moyenne des notes" +
                    "\n0----Quitter" +
                    "\n\nFaîtes votre choix : ");
                entreeUtilisateur = int.Parse(Console.ReadLine());

                
                switch(entreeUtilisateur)
                {
                    //ÉCRAN DE SAISIE DE NOTES :
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("------ Saisir les notes ------\n(999 pour stopper la saisie)\n");
                        Console.ResetColor();
                        do
                        {
                            Console.Write("Merci de saisir la note " + (listeDesNotes.Count + 1) + " (sur /20) : ");
                            entreeUtilisateur = int.Parse(Console.ReadLine());
                            if (entreeUtilisateur < 0 || entreeUtilisateur > 20 && entreeUtilisateur != 999) //<--Filtre des notes inférieures à 0 ou supérieures à 20.
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\tErreur de saisie, la note est sur 20 !");//<--Message d'erreur pour note invalide.
                                Console.ResetColor();
                            }
                            else if (entreeUtilisateur != 999) //<--Ajout d'une note valide.
                            {
                                listeDesNotes.Add(entreeUtilisateur); //<--Ajout de la note à la liste des notes.
                            };
                        } while (entreeUtilisateur != 999); //<--Sortie vers MENU PRINCIPAL
                        Console.Clear();
                    break;

                    //ÉCRAN DE LA PLUS GRANDE NOTE :
                    case 2:
                        if (listeDesNotes.Count == 0)
                        {   //Affichage d'un message d'erreur si aucune note n'a été entrée.
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Vous devez d'abord rentrer des notes !");
                            Console.ResetColor();
                        } 
                        else 
                        {   //Calcul et affichage de la note la plus grande.
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("------ La plus grande note ------\n");
                            for (int i = 0; i < listeDesNotes.Count; i++)
                            {
                                if (plusGrandeNote <= listeDesNotes[i])
                                {
                                    plusGrandeNote = listeDesNotes[i];
                                };
                            }
                            Console.WriteLine("La note la plus haute est : " + plusGrandeNote + "/20\n");
                            Console.ResetColor();
                        };
                        break;

                    //ÉCRAN DE LA PLUS PETITE NOTE :
                    case 3:
                        if (listeDesNotes.Count == 0)
                        {   //Affichage d'un message d'erreur si aucune note n'a été entrée.
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Vous devez d'abord rentrer des notes !");
                            Console.ResetColor();
                        }
                        else
                        {   //Calcul et affichage de la note la plus petite.
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("------ La plus petite note ------\n");
                            for (int i = 0; i < listeDesNotes.Count; i++)
                            {
                                if (plusPetiteNote >= listeDesNotes[i])
                                {
                                    plusPetiteNote = listeDesNotes[i];
                                };
                            }
                            Console.WriteLine("La note la plus basse est : " + plusPetiteNote + "/20\n");
                            Console.ResetColor();
                        };
                        break;

                    //ÉCRAN DE LA MOYENNE :
                    case 4:
                        if (listeDesNotes.Count == 0)
                        {   //Affichage d'un message d'erreur si aucune note n'a été entrée.
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Vous devez d'abord rentrer des notes !");
                            Console.ResetColor();
                        }
                        else
                        {   //Calcul et affichage de la moyenne des notes.
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("------ La moyenne des notes ------\n");
                            for (int i = 0; i < listeDesNotes.Count; i++)
                            {
                                moyenneDesNotes += listeDesNotes[i];
                            };
                            moyenneDesNotes /= listeDesNotes.Count;
                            Math.Round(moyenneDesNotes, 1);
                            Console.WriteLine("La moyenne est de : " + moyenneDesNotes + "/20\n");
                            Console.ResetColor();
                        };
                        break;
                }
            } while (entreeUtilisateur != 0);
            Environment.Exit(0);
        }
    }
}