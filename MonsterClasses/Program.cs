using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayMenu();
            DisplayClosingScreen();            
        }

        
        #region  Using 3 Different constructors to instantiate objects
        static void InitializeSeaMonster(List<SeaMonster> seaMonsters)
        {
            SeaMonster suzy = new SeaMonster(99, "Suzy", 100)
            {
                Id = 99,
                Name = "Suzy",
                Age = 478,
                Gold = 1000,
                HitPoints = 100,
                HasGills = true,
                SeaName = "Baltic Sea"
            };
            seaMonsters.Add(suzy);

            SeaMonster globby = new SeaMonster(45, "globby", 125)
            {
                Age = 555,
                Gold = 799,
                HasGills = true,
                SeaName = "Red Sea",
                ArmourCarried = Monster.Armour.WETSUIT,
                WeaponsCarried = Monster.Weapons.WATERCANON,

            };
            seaMonsters.Add(globby);
        }

        static void InitializeSpaceMonster(List<SpaceMonster> spaceMonsters)
        {
            
            SpaceMonster bill = new SpaceMonster("Bill")
            {
                Id = 195,
                Name= "bill",
                Age = 1001,
                Gold = 600,
                HitPoints = 125,                
                HasSpaceship = true
                
            };
            spaceMonsters.Add(bill);

            SpaceMonster kuhuana = new SpaceMonster("Kuhuana")
            {
                Id = 117,
                Age = 1671,
                Gold = 12000,
                HitPoints = 225,
                HasSpaceship = true,
                WeaponsCarried = Monster.Weapons.BEAMRAY,
                ArmourCarried = Monster.Armour.CHESTPLATE
            };
            spaceMonsters.Add(kuhuana);
        }
        
        static void InitializeTradeStore(List<TradeStore> tradeStore)
        {

            TradeStore spaceClerk = new TradeStore()
            {
                Id = 101,
                Name = "Space Store Clerk",
                Age = 5000,
                Gold = 1000000,
                HitPoints = 1000000,
                ArmourCarried = Monster.Armour.HELMET,
                WeaponsCarried = Monster.Weapons.BEAMRAY,
                ArmourInventorySlot1 = Monster.Armour.CHESTPLATE,
                ArmourSlotPrice1 = 75,
                ArmourInventorySlot2 = Monster.Armour.HELMET,
                ArmourSlotPrice2 = 50,
                ArmourInventorySlot3 = Monster.Armour.WETSUIT,
                ArmourSlotPrice3 = 25,
                WeaponInventorySlot1 = Monster.Weapons.BEAMRAY,
                WeaponSlotPrice1 = 75,
                WeaponInventorySlot2 = Monster.Weapons.CATAPULT,
                WeaponSlotPrice2 = 50,
                WeaponInventorySlot3 = Monster.Weapons.WATERCANON,
                WeaponSlotPrice3 = 25              

            };
            TradeStore seaClerk = new TradeStore()
            {
                Id = 1,
                Name = "Sea Store Clerk",
                Age = 5000,
                Gold = 1000000,
                HitPoints = 1000000,
                ArmourCarried = Monster.Armour.WETSUIT,
                WeaponsCarried = Monster.Weapons.WATERCANON,
                ArmourInventorySlot1 = Monster.Armour.WETSUIT,
                ArmourSlotPrice1 = 75,
                ArmourInventorySlot2 = Monster.Armour.HELMET,
                ArmourSlotPrice2 = 50,
                ArmourInventorySlot3 = Monster.Armour.CHESTPLATE,
                ArmourSlotPrice3 = 25,
                WeaponInventorySlot1 = Monster.Weapons.WATERCANON,
                WeaponSlotPrice1 = 75,
                WeaponInventorySlot2 = Monster.Weapons.CATAPULT,
                WeaponSlotPrice2 = 50,
                WeaponInventorySlot3 = Monster.Weapons.BEAMRAY,
                WeaponSlotPrice3 = 25
            };
            tradeStore.Add(seaClerk);
        }
        #endregion

        //
        // MainMenu
        //
        static void DisplayMenu()
        {
            List<SeaMonster> seaMonsters = new List<SeaMonster>();
            List<SpaceMonster> spaceMonsters = new List<SpaceMonster>();
            List<TradeStore> tradeStores = new List<TradeStore>();
            bool exiting = false;
            InitializeSeaMonster(seaMonsters);
            InitializeSpaceMonster(spaceMonsters);
            InitializeTradeStore(tradeStores);

            while (!exiting)
            {
                DisplayHeader("Main Menu");

                Console.WriteLine("\t1 Display All Sea Monsters");
                Console.WriteLine("\t2) Interact with space monster");
                Console.WriteLine("\t3) Interact with sea monster");
                Console.WriteLine("\t4) Edit Monster Info");
                Console.WriteLine("\t5) Exit");

                Console.Write("Enter Choice:");

                int menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        DisplayMonsterInfo(seaMonsters, spaceMonsters, tradeStores);
                        break;
                    case 2:
                        DisplaySpaceMonster(spaceMonsters, seaMonsters, tradeStores);
                        break;
                    case 3:
                        DisplaySeaMonster(seaMonsters, spaceMonsters, tradeStores);
                        break;
                    case 4:
                        DisplayEditMonster(seaMonsters, spaceMonsters);
                        break;
                    case 5:
                        exiting = true;
                        break;
                    default:
                        Console.WriteLine("Please Enter a valid Response. ");
                        break;
                }

            }
        }
        

        private static void initializewithdifferentconstructor1(List<SeaMonster> seamonsters)
        {
            
        }


        //
        // choose which type of monster to edit
        //
        private static void DisplayEditMonster(List<SeaMonster> seaMonsters, List<SpaceMonster> spaceMonsters)
        {
            DisplayHeader("Edit Monster");
            string monsterName = null;
            string monsterType = null;
            bool validResponse = false;
            Console.WriteLine("Which Type of Monster would you like to Edit? 1)Space Monster 2)Sea Monster");
            do
            {
                int userResponse = int.Parse(Console.ReadLine());
                switch (userResponse)
                {
                    case 1:
                        monsterType = "SpaceMonster";
                        validResponse = true;
                        break;
                    case 2:
                        monsterType = "SeaMonster";
                        validResponse = true;
                        break;
                    default:
                        validResponse = false;
                        break;
                }
            } while (!validResponse);

            switch (monsterType)
            {
                case "SpaceMonster":
                    foreach (SpaceMonster spaceMonster in spaceMonsters)
                    {
                        Console.WriteLine(spaceMonster.Name);
                    }
                    Console.WriteLine("Which monster would you like to edit");
                    do
                    {
                        monsterName = Console.ReadLine();
                        foreach (SpaceMonster spaceMonster in spaceMonsters)
                        {
                            if (monsterName == spaceMonster.Name)
                            {
                                DisplayEditSpaceMonster(spaceMonster);
                                validResponse = true;
                            }
                            else
                            {
                                Console.WriteLine("Please try again unfound monster.");
                                validResponse = false;
                            }
                        }
                    } while (!validResponse);
                    break;
                case "SeaMonster":
                    foreach (SeaMonster seaMonster in seaMonsters)
                    {
                        Console.WriteLine(seaMonster.Name);
                    }
                    Console.WriteLine("which monster would you like to edit?");
                    do
                    {
                        monsterName = Console.ReadLine();
                        foreach (SeaMonster seaMonster in seaMonsters)
                        {
                            if (monsterName == seaMonster.Name)
                            {
                                DisplayEditSeaMonster(seaMonster);
                                validResponse = true;
                            }
                            else
                            {
                                Console.WriteLine("Please try again unfound monster.");
                                validResponse = false;
                            }
                        }
                    } while (!validResponse);                   
                    break;
                default:
                    break;
            }
        }


        //
        // Edit any SeaMOnster
        //
        private static void DisplayEditSeaMonster(SeaMonster seaMonster)
        {

            bool validResponse = false;
            Console.Write("Enter the monster's correct Name. ");
            seaMonster.Name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the monster's correct age. ");
            do
            {
                validResponse = int.TryParse(Console.ReadLine(), out int age);
                seaMonster.Age = age;
                if (!validResponse)
                {
                    Console.Write("Pleae enter a correct Age");
                }
            } while (!validResponse);
            Console.WriteLine();
            Console.Write("Enter the monster's correct Id. ");
            do
            {
                validResponse = int.TryParse(Console.ReadLine(), out int Id);
                seaMonster.Id = Id;
                if (!validResponse)
                {
                    Console.Write("Pleae enter a correct Id");
                }
            } while (!validResponse);
            Console.WriteLine();
            Console.Write("Enter the monster's correct Gold. ");
            do
            {
                validResponse = int.TryParse(Console.ReadLine(), out int gold);
                seaMonster.Gold = gold;
                if (!validResponse)
                {
                    Console.Write("Please enter a correct amount");
                }
            } while (!validResponse);
            Console.WriteLine();
            Console.Write("Enter the monster's correct hit points. ");
            do
            {
                validResponse = int.TryParse(Console.ReadLine(), out int hitPoint);
                seaMonster.HitPoints = hitPoint;
                if (!validResponse)
                {
                    Console.Write("Please enter a correct amount");
                }
            } while (!validResponse);
            Console.WriteLine();
            Console.Write("Enter the monster's correct Armour. NONE,HELMET,CHESTPLATE,WETSUIT");
            do
            {
                string userAnswer = Console.ReadLine().ToUpper();
                switch (userAnswer)
                {
                    case "HELMET":
                        seaMonster.ArmourCarried = Monster.Armour.HELMET;
                        validResponse = true;
                        break;
                    case "CHESTPLATE":
                        seaMonster.ArmourCarried = Monster.Armour.CHESTPLATE;
                        validResponse = true;
                        break;
                    case "WETSUIT":
                        seaMonster.ArmourCarried = Monster.Armour.WETSUIT;
                        validResponse = true;
                        break;
                    default:
                        Console.WriteLine("Please Enter Armour Correctly.");
                        validResponse = false;
                        break;
                }
            } while (!validResponse);
            Console.WriteLine();
            Console.Write("Enter the monster's correct WEAPON: NONE,BEAMRAY,WATERCANNON,CATAPULT");
            do
            {

                string userAnswer = Console.ReadLine().ToUpper();
                switch (userAnswer)
                {
                    case "HELMET":
                        seaMonster.ArmourCarried = Monster.Armour.HELMET;
                        validResponse = true;
                        break;
                    case "CHESTPLATE":
                        seaMonster.ArmourCarried = Monster.Armour.CHESTPLATE;
                        validResponse = true;
                        break;
                    case "WETSUIT":
                        seaMonster.ArmourCarried = Monster.Armour.WETSUIT;
                        validResponse = true;
                        break;
                    default:
                        Console.WriteLine("Please Enter Armour Correctly.");
                        validResponse = false;
                        break;
                }
            } while (!validResponse);

            DisplayContinuePrompt();
        }


        //
        // Edit Any SpaceMonster 
        //
        private static void DisplayEditSpaceMonster(SpaceMonster spaceMonster)
        {
            
            bool validResponse = false;
            Console.Write("Enter the monster's correct Name. ");
            spaceMonster.Name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the monster's correct age. ");
            do
            {               
                validResponse = int.TryParse(Console.ReadLine(), out int age);
                spaceMonster.Age = age;
                if (!validResponse)
                {
                    Console.Write("Pleae enter a correct Age");
                }
            } while (!validResponse);
            Console.WriteLine();
            Console.Write("Enter the monster's correct Id. ");
            do
            {                
                validResponse = int.TryParse(Console.ReadLine(), out int Id);
                spaceMonster.Id = Id;
                if (!validResponse)
                {
                    Console.Write("Pleae enter a correct Id");
                }
            } while (!validResponse);
            Console.WriteLine();
            Console.Write("Enter the monster's correct Gold. ");
            do
            {               
                validResponse = int.TryParse(Console.ReadLine(), out int gold);
                spaceMonster.Gold = gold;
                if (!validResponse)
                {
                    Console.Write("Please enter a correct amount");
                }
            } while (!validResponse);
            Console.WriteLine();
            Console.Write("Enter the monster's correct hit points. ");
            do
            {                
                validResponse = int.TryParse(Console.ReadLine(), out int hitPoint);
                spaceMonster.HitPoints = hitPoint;
                if (!validResponse)
                {
                    Console.Write("Please enter a correct amount");
                }
            } while (!validResponse);
            Console.WriteLine();
            Console.Write("Enter the monster's correct Armour. NONE,HELMET,CHESTPLATE,WETSUIT");
            do
            {               
                string userAnswer = Console.ReadLine().ToUpper();
                switch (userAnswer)
                {
                    case "HELMET":
                        spaceMonster.ArmourCarried = Monster.Armour.HELMET;
                        validResponse = true;
                        break;
                    case "CHESTPLATE":
                        spaceMonster.ArmourCarried = Monster.Armour.CHESTPLATE;
                        validResponse = true;
                        break;
                    case "WETSUIT":
                        spaceMonster.ArmourCarried = Monster.Armour.WETSUIT;
                        validResponse = true;
                        break;
                    default:
                        Console.WriteLine("Please Enter Armour Correctly.");
                        validResponse = false;
                        break;
                }
            } while (!validResponse);
            Console.WriteLine();
            Console.Write("Enter the monster's correct WEAPON: NONE,BEAMRAY,WATERCANNON,CATAPULT");
            do
            {

                string userAnswer = Console.ReadLine().ToUpper();
                switch (userAnswer)
                {
                    case "HELMET":
                        spaceMonster.ArmourCarried = Monster.Armour.HELMET;
                        validResponse = true;
                        break;
                    case "CHESTPLATE":
                        spaceMonster.ArmourCarried = Monster.Armour.CHESTPLATE;
                        validResponse = true;
                        break;
                    case "WETSUIT":
                        spaceMonster.ArmourCarried = Monster.Armour.WETSUIT;
                        validResponse = true;
                        break;
                    default:
                        Console.WriteLine("Please Enter Armour Correctly.");
                        validResponse = false;
                        break;
                }
            } while (!validResponse);

            DisplayContinuePrompt();
        }

        static void DisplayMonsterInfo(List<SeaMonster> seaMonsters, List<SpaceMonster> spaceMonsters, List<TradeStore>tradeStores)
        {
            DisplayHeader("Monster Information");

            DisplayAllMonsterInfo(seaMonsters, spaceMonsters, tradeStores);

            DisplayContinuePrompt();
        }


        //
        // Displays All MOnsters and stores
        //
        private static void DisplayAllMonsterInfo(List<SeaMonster> seaMonsters, List<SpaceMonster> spaceMonsters, List<TradeStore> tradeStores)
        {
            foreach (SeaMonster seaMonster in seaMonsters)
            {
                Console.WriteLine($"{seaMonster.Name}, {seaMonster.Id}, {seaMonster.IsSpecies}, {seaMonster.HitPoints}, {seaMonster.Gold}");
            }
            foreach (SpaceMonster spaceMonster in spaceMonsters)
            {
                Console.WriteLine($"{spaceMonster.Name}, {spaceMonster.Id}, {spaceMonster.IsSpecies}, {spaceMonster.HitPoints}, {spaceMonster.Gold}");
            }
            foreach (TradeStore tradeStore in tradeStores)
            {
                Console.WriteLine($"{tradeStore.Name}, {tradeStore.Id}, {tradeStore.IsSpecies}, {tradeStore.HitPoints}, {tradeStore.Gold}");
            }
        }

        //
        // Display method for spaceMONSTER that leads to INteractions
        //
        static void DisplaySpaceMonster(List<SpaceMonster> spaceMonsters, List<SeaMonster> seaMonsters, List<TradeStore> tradeStores)
        {
            bool exiting = false;
            string monsterChoosen;
            bool validResponse = false;
            Console.WriteLine("Here are the Space Monsters Available:");
            foreach (SpaceMonster spaceMonster in spaceMonsters)
            {
                Console.WriteLine(spaceMonster.Name);
            }

            Console.WriteLine();
            do
            {
                Console.Write("Which Space Monster would you like to interact with? ");
                monsterChoosen = Console.ReadLine();
                foreach (SpaceMonster spaceMonster in spaceMonsters)
                {
                    if (spaceMonster.Name == monsterChoosen)
                    {
                        validResponse = true;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter an Excisting Monster.");
                        validResponse = false;
                    }
                }
            } while (!validResponse);

            Console.WriteLine();
            foreach (SpaceMonster spaceMonster in spaceMonsters)
            {
                if (spaceMonster.Name == monsterChoosen)
                {
                    spaceMonster.Greeting();
                    Console.WriteLine($"Id: {spaceMonster.Id}");
                    Console.WriteLine($"Name: {spaceMonster.Name}");
                    Console.WriteLine($"Age: {spaceMonster.Age}");
                    Console.WriteLine($"Active: {(spaceMonster.IsActive() ? "Yes" : "No")}");
                    Console.WriteLine();
                    Console.WriteLine($"What would you like {spaceMonster.Name} to do:");
                    Console.WriteLine("\t\t\t\t1) Trade");
                    Console.WriteLine("\t\t\t\t2) Battle");
                    Console.WriteLine("\t\t\t\t3) Chat");

                    int menuChoice = int.Parse(Console.ReadLine());
                    do
                    {
                        switch (menuChoice)
                        {
                            case 1:
                                DisplayTradeInterface(spaceMonster, spaceMonsters, seaMonsters, tradeStores);
                                break;
                            case 2:
                                DisplayBattleInterface(spaceMonster, spaceMonsters, seaMonsters, tradeStores);
                                break;
                            case 3:
                                DisplayChatInterface(spaceMonster, seaMonsters, tradeStores);
                                break;
                            case 4:
                                exiting = true;
                                break;
                            default:
                                Console.WriteLine("Please Enter a valid Response. ");
                                break;
                        }
                    } while (exiting);
                    
                }
            }                   
            
        }

        //
        // Displays seamonster and the options available to interact with
        //
        static void DisplaySeaMonster(List<SeaMonster> seaMonsters, List<SpaceMonster> spaceMonsters, List<TradeStore> tradeStores)
        {
            bool exiting = false;
            string monsterChoosen;
            bool validResponse = false;
            Console.WriteLine("Here are the Space Monsters Available:");
            foreach (SeaMonster seaMonster in seaMonsters)
            {
                Console.WriteLine(seaMonster.Name);
            }

            Console.WriteLine();
            do
            {
                Console.Write("Which Space Monster would you like to interact with? ");
                monsterChoosen = Console.ReadLine();
                foreach (SeaMonster seaMonster in seaMonsters)
                {
                    if (seaMonster.Name == monsterChoosen)
                    {
                        validResponse = true;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter an Excisting Monster.");
                        validResponse = false;
                    }
                }
            } while (!validResponse);

            Console.WriteLine();
            foreach (SeaMonster seaMonster in seaMonsters)
            {
                if (seaMonster.Name == monsterChoosen)
                {
                    seaMonster.Greeting();
                    seaMonster.DisplaySpecies(seaMonster.Id);
                    Console.WriteLine($"Id: {seaMonster.Id}");
                    Console.WriteLine($"Name: {seaMonster.Name}");
                    Console.WriteLine($"Age: {seaMonster.Age}");
                    Console.WriteLine($"Feeling Aggresive: {(seaMonster.WillAttack() ? "yes" : "No")}");
                    Console.WriteLine($"Active: {(seaMonster.IsActive() ? "Yes" : "No")}");                    
                    Console.WriteLine();

                    Console.WriteLine($"What would you like {seaMonster.Name} to do:");
                    Console.WriteLine("\t\t\t\t1) Trade");
                    Console.WriteLine("\t\t\t\t2) Battle");
                    Console.WriteLine("\t\t\t\t3) Chat");

                    int menuChoice = int.Parse(Console.ReadLine());
                    do
                    {
                        switch (menuChoice)
                        {
                            case 1:
                                DisplaySeaTradeInterface(seaMonster, spaceMonsters, tradeStores);
                                break;
                            case 2:
                                DisplaySeaBattleInterface(seaMonster, spaceMonsters);
                                break;
                            case 3:
                                DisplaySeaChatInterface(seaMonster, spaceMonsters, tradeStores);
                                break;
                            case 4:
                                exiting = true;
                                break;
                            default:
                                Console.WriteLine("Please Enter a valid Response. ");
                                break;
                        }
                    } while (exiting);

                }
            }

        }


        /// <summary>
        /// Interface Methods offiliated with spaceMONSTER
        /// </summary>
        /// <param name="spaceMonster"></param>
        /// <param name="seaMonsters"></param>
        /// <param name="tradeStores"></param>
        #region Interface Methods for SPACEMONSTER
        //
        // As spaceMonster choose which object to chat with
        //
        private static void DisplayChatInterface(SpaceMonster spaceMonster, List<SeaMonster> seaMonsters, List<TradeStore> tradeStores)
        {
            bool validResponse = false;
            string userChoice;

            do
            {
                Console.WriteLine("Who would you like to talk to 1) Sea Monster 2) Trade Store? ");
                int chatChoice = int.Parse(Console.ReadLine());

                switch (chatChoice)
                {
                    case 1:
                        validResponse = true;
                        foreach (SeaMonster seaMonster in seaMonsters)
                        {
                            Console.WriteLine(seaMonster.Name);
                        }
                        Console.WriteLine();

                        Console.Write("Please type a name: ");
                        userChoice = Console.ReadLine();
                        foreach (SeaMonster seaMonster in seaMonsters)
                        {
                            if (userChoice == seaMonster.Name)
                            {
                                TradeStore tradeStore = null;
                                DisplayPersonalChat(spaceMonster, tradeStore, seaMonster);
                            }
                        }
                        break;
                    case 2:
                        validResponse = true;
                        foreach (TradeStore tradeStore in tradeStores)
                        {
                            Console.WriteLine(tradeStore.Name);
                        }
                        Console.WriteLine();

                        Console.Write("Please type a name: ");
                        userChoice = Console.ReadLine();
                        foreach (TradeStore tradeStore in tradeStores)
                        {
                            if (userChoice == tradeStore.Name)
                            {
                                SeaMonster seaMonster = null;
                                DisplayPersonalChat(spaceMonster, tradeStore, seaMonster);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Please Enter a Correct Response.");
                        break;
                }

            } while (!validResponse);

        }

        //
        // spaceMonsters chat played out
        //
        private static void DisplayPersonalChat(SpaceMonster spaceMonster, TradeStore tradeStore, SeaMonster seaMonster)
        {
            Random randomNumber = new Random();
            int actionProbability = randomNumber.Next(0, 101);

            switch (spaceMonster.MonsterInteractionResponse())
            {
                case Monster.MonsterCommunications.NONE:
                    break;
                case Monster.MonsterCommunications.HAPPY:
                    Console.WriteLine($"{spaceMonster.Name} says: Alright I'm feeling good let's get busy!");
                    break;
                case Monster.MonsterCommunications.SAD:
                    break;
                case Monster.MonsterCommunications.BEG:
                    Console.WriteLine($"{spaceMonster.Name} says: Please Please Please i just need a little help.");
                    break;
                case Monster.MonsterCommunications.ANGRY:
                    if (actionProbability >= 67)
                    {
                        Console.WriteLine($"{spaceMonster.Name} says: Can't you help me out a little?");
                    }
                    else if (actionProbability >= 34)
                    {
                        Console.WriteLine($"{spaceMonster.Name} says: This is starting to become rediculous!");
                    }
                    else
                    {
                        Console.WriteLine($"{spaceMonster.Name} says: For Crying out loud!");
                    }
                    break;
                case Monster.MonsterCommunications.TRADE:
                    Console.WriteLine($"{ spaceMonster.Name} says: Hey would you sell or trade me a weapon or armour?");
                    break;
                case Monster.MonsterCommunications.THREATEN:
                    if (actionProbability >= 67)
                    {
                        Console.WriteLine($"{spaceMonster.Name} says: I'm gonna be coming after you boy");
                    }
                    else if (actionProbability >= 34)
                    {
                        Console.WriteLine($"{spaceMonster.Name} says: Listen here give me everything i need and you wont get hurt!");
                    }
                    else
                    {
                        Console.WriteLine($"{spaceMonster.Name} says: You better watch your back!");
                    }
                    break;
                case Monster.MonsterCommunications.STUNNED:
                    break;
                default:
                    break;
            }

            if (seaMonster != null)
            {
                switch (seaMonster.MonsterInteractionResponse())
                {
                    case Monster.MonsterCommunications.NONE:
                        break;
                    case Monster.MonsterCommunications.HAPPY:
                        Console.WriteLine($"{seaMonster.Name} says: Okay let me see if I can help");
                        break;
                    case Monster.MonsterCommunications.SAD:
                        Console.WriteLine($"{seaMonster.Name} says: I don't think I'm strong enough to help at this point in time.");
                        break;
                    case Monster.MonsterCommunications.BEG:
                        Console.WriteLine($"{seaMonster.Name} says: Please Dont Hurt Me!");
                        break;
                    case Monster.MonsterCommunications.ANGRY:
                        Console.WriteLine($"{seaMonster.Name} says: If you wanna fight lets do it! Throw the first punch!");
                        break;
                    case Monster.MonsterCommunications.TRADE:
                        Console.WriteLine($"{seaMonster.Name} says: I would love to trade with you but first I need to know what you have available.");
                        break;
                    case Monster.MonsterCommunications.THREATEN:
                        Console.WriteLine($"{seaMonster.Name} says: Listen here pip squeek, I'll crush you!");
                        break;
                    case Monster.MonsterCommunications.STUNNED:
                        break;
                    default:
                        break;
                }
            }
            DisplayContinuePrompt();
        }

        //
        // As SpaceMonster choose which object to battle
        //
        private static void DisplayBattleInterface(SpaceMonster spaceMonster, List<SpaceMonster> spaceMonsters, List<SeaMonster> seaMonsters, List<TradeStore> tradeStores)
        {
            bool validResponse = false;
            string userAnswer;
            Console.WriteLine("Which Monster would you like to battle?");
            foreach (SeaMonster seaMonster in seaMonsters)
            {
                Console.WriteLine(seaMonster.Name);
            }

            Console.Write("Type your answer: ");
            do
            {
                userAnswer = Console.ReadLine();
                foreach (SeaMonster seaMonster in seaMonsters)
                {
                    if (userAnswer == seaMonster.Name)
                    {
                        DisplayPlayOutBattle(spaceMonster, seaMonster);
                        validResponse = true;
                    }
                }
            } while (!validResponse);

        }

        //
        // spaceMonsters battle Played out
        //
        private static void DisplayPlayOutBattle(SpaceMonster spaceMonster, SeaMonster seaMonster)
        {
            Console.WriteLine($"{spaceMonster.Name} attacks {seaMonster.Name} with {spaceMonster.WeaponsCarried} and {seaMonster.Name} {seaMonster.MonsterBattleResponse()}.");
            DisplayContinuePrompt();
        }

        //
        // As SpaceMonster choose which store to trade with
        //
        private static void DisplayTradeInterface(SpaceMonster spaceMonster, List<SpaceMonster> spaceMonsters, List<SeaMonster> seaMonsters, List<TradeStore> tradeStores)
        {
            DisplayHeader("Trade With The Trade Store");
            bool validResponse = false;
            string userAnswer;
            Console.WriteLine("Which Trade store would you like to trade with? ");
            foreach (TradeStore tradeStore in tradeStores)
            {
                Console.WriteLine(tradeStore.Name);
            }
            Console.WriteLine("Type the name of the store you would like to trade with.");
            do
            {
                userAnswer = Console.ReadLine();
                foreach (TradeStore tradestore in tradeStores)
                {
                    if (userAnswer == tradestore.Name)
                    {
                        DisplaySpaceTradeWithStore(spaceMonster, tradestore);
                        validResponse = true;
                    }
                    else
                    {
                        validResponse = false;
                    }
                }
            } while (!validResponse);
        }

        //
        // spaceMonster trade with store played out
        //
        private static void DisplaySpaceTradeWithStore(SpaceMonster spaceMonster, TradeStore tradestore)
        {
            Console.WriteLine($"{spaceMonster.Name} trades with {tradestore.Name} and" +
               $"\n{spaceMonster.Name} recieves Armour: {spaceMonster.MonsterTradeArmourResponse(tradestore)} " +
               $"\nand Weapon: {spaceMonster.MonsterTradeWeaponResponse(tradestore)}");
        }
        #endregion

        /// <summary>
        ///  Methods Dealing with SeaMONSTER INTERACTION
        /// </summary>
        /// <param name="seaMonster"></param>
        /// <param name="spaceMonsters"></param>
        /// <param name="tradeStores"></param>
        #region Interface Methods for SEAMONSTER


        //
        // As seamonster you choose which store to trade with
        //
        private static void DisplaySeaTradeInterface(SeaMonster seaMonster, List<SpaceMonster> spaceMonsters, List<TradeStore> tradeStores)
        {
            DisplayHeader("Trade With The Trade Store");
            bool validResponse = false;
            string userAnswer;
            Console.WriteLine("Which Trade store would you like to trade with? ");
            foreach (TradeStore tradeStore in tradeStores)
            {
                Console.WriteLine(tradeStore.Name);
            }
            Console.WriteLine("Type the name of the store you would like to trade with.");
            do
            {
                userAnswer = Console.ReadLine();
                foreach (TradeStore tradestore in tradeStores)
                {
                    if (userAnswer == tradestore.Name)
                    {
                        DisplaySeaTradeWithStore(seaMonster, tradestore);
                        validResponse = true;
                    }
                    else
                    {
                        validResponse = false;
                    }
                }
            } while (!validResponse);


        }

        //
        // Trade with tradestore is played out
        //
        private static void DisplaySeaTradeWithStore(SeaMonster seaMonster, TradeStore tradestore)
        {
            Console.WriteLine($"{seaMonster.Name} trades with {tradestore.Name} and" +
                $"\n{seaMonster.Name} recieves Armour: {seaMonster.MonsterTradeArmourResponse(tradestore)} " +
                $"\nand Weapon: {seaMonster.MonsterTradeWeaponResponse(tradestore)}");
        }
        //
        // as seamonster you choose who you want to battle
        //
        private static void DisplaySeaBattleInterface(SeaMonster seaMonster, List<SpaceMonster> spaceMonsters)
        {
            bool validResponse = false;
            string userAnswer;
            Console.WriteLine("Which Monster would you like to battle?");
            foreach (SpaceMonster spaceMonster in spaceMonsters)
            {
                Console.WriteLine(spaceMonster.Name);
            }

            Console.Write("Type your answer: ");
            do
            {
                userAnswer = Console.ReadLine();
                foreach (SpaceMonster spaceMonster in spaceMonsters)
                {
                    if (userAnswer == spaceMonster.Name)
                    {
                        DisplayPlayOutSeaBattle(spaceMonster, seaMonster);
                        validResponse = true;
                    }
                }
            } while (!validResponse);
        }
        //
        // as seamonster the battle is played out
        //
        private static void DisplayPlayOutSeaBattle(SpaceMonster spaceMonster, SeaMonster seaMonster)
        {
            Console.WriteLine($"{seaMonster.Name} attacks {spaceMonster.Name} with {seaMonster.WeaponsCarried} and {spaceMonster.Name} {spaceMonster.MonsterBattleResponse()}s.");
            DisplayContinuePrompt();
        }

        //
        // as seamonster you choose who you want to talk to
        //
        private static void DisplaySeaChatInterface(SeaMonster seaMonster, List<SpaceMonster> spaceMonsters, List<TradeStore> tradeStores)
        {
            bool validResponse = false;
            string userChoice;

            do
            {
                Console.WriteLine("Who would you like to talk to 1) Space Monster 2) Trade Store? ");
                int chatChoice = int.Parse(Console.ReadLine());

                switch (chatChoice)
                {
                    case 1:
                        validResponse = true;
                        foreach (SpaceMonster spaceMonster in spaceMonsters)
                        {
                            Console.WriteLine(seaMonster.Name);
                        }
                        Console.WriteLine();

                        Console.Write("Please type a name: ");
                        userChoice = Console.ReadLine();
                        foreach (SpaceMonster spaceMonster in spaceMonsters)
                        {
                            if (userChoice == seaMonster.Name)
                            {
                                TradeStore tradeStore = null;
                                DisplaySeaPersonalChat(spaceMonster, tradeStore, seaMonster);
                            }
                        }
                        break;
                    case 2:
                        validResponse = true;
                        foreach (TradeStore tradeStore in tradeStores)
                        {
                            Console.WriteLine(tradeStore.Name);
                        }
                        Console.WriteLine();

                        Console.Write("Please type a name: ");
                        userChoice = Console.ReadLine();
                        foreach (TradeStore tradeStore in tradeStores)
                        {
                            if (userChoice == tradeStore.Name)
                            {
                                SpaceMonster spaceMonster = null;
                                DisplaySeaPersonalChat(spaceMonster, tradeStore, seaMonster);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Please Enter a Correct Response.");
                        break;
                }

            } while (!validResponse);
        }

        //
        // Display converstion of seamonster with choosen object
        //
        private static void DisplaySeaPersonalChat(SpaceMonster spaceMonster, TradeStore tradeStore, SeaMonster seaMonster)
        {
            Random randomNumber = new Random();
            int actionProbability = randomNumber.Next(0, 101);

            switch (seaMonster.Communications)
            {
                case Monster.MonsterCommunications.NONE:
                    break;
                case Monster.MonsterCommunications.HAPPY:
                    Console.WriteLine($"{spaceMonster.Name} says: Alright I'm feeling good let's get busy!");
                    break;
                case Monster.MonsterCommunications.SAD:
                    break;
                case Monster.MonsterCommunications.BEG:
                    Console.WriteLine($"{spaceMonster.Name} says: Please Please Please i just need a little help.");
                    break;
                case Monster.MonsterCommunications.ANGRY:
                    if (actionProbability >= 67)
                    {
                        Console.WriteLine($"{spaceMonster.Name} says: Can't you help me out a little?");
                    }
                    else if (actionProbability >= 34)
                    {
                        Console.WriteLine($"{spaceMonster.Name} says: This is starting to become rediculous!");
                    }
                    else
                    {
                        Console.WriteLine($"{spaceMonster.Name} says: For Crying out loud!");
                    }
                    break;
                case Monster.MonsterCommunications.TRADE:
                    Console.WriteLine($"{ spaceMonster.Name} says: Hey would you sell or trade me a weapon or armour?");
                    break;
                case Monster.MonsterCommunications.THREATEN:
                    if (actionProbability >= 67)
                    {
                        Console.WriteLine($"{spaceMonster.Name} says: I'm gonna be coming after you boy");
                    }
                    else if (actionProbability >= 34)
                    {
                        Console.WriteLine($"{spaceMonster.Name} says: Listen here give me everything i need and you wont get hurt!");
                    }
                    else
                    {
                        Console.WriteLine($"{spaceMonster.Name} says: You better watch your back!");
                    }
                    break;
                case Monster.MonsterCommunications.STUNNED:
                    break;
                default:
                    break;
            }

            if (spaceMonster != null)
            {
                switch (spaceMonster.Communications)
                {
                    case Monster.MonsterCommunications.NONE:
                        break;
                    case Monster.MonsterCommunications.HAPPY:
                        Console.WriteLine($"{seaMonster.Name} says: Okay let me see if I can help");
                        break;
                    case Monster.MonsterCommunications.SAD:
                        Console.WriteLine($"{seaMonster.Name} says: I don't think I'm strong enough to help at this point in time.");
                        break;
                    case Monster.MonsterCommunications.BEG:
                        Console.WriteLine($"{seaMonster.Name} says: Please Dont Hurt Me!");
                        break;
                    case Monster.MonsterCommunications.ANGRY:
                        Console.WriteLine($"{seaMonster.Name} says: If you wanna fight lets do it! Throw the first punch!");
                        break;
                    case Monster.MonsterCommunications.TRADE:
                        Console.WriteLine($"{seaMonster.Name} says: I would love to trade with you but first I need to know what you have available.");
                        break;
                    case Monster.MonsterCommunications.THREATEN:
                        Console.WriteLine($"{seaMonster.Name} says: Listen here pip squeek, I'll crush you!");
                        break;
                    case Monster.MonsterCommunications.STUNNED:
                        break;
                    default:
                        break;
                }
            }

        }
        #endregion

        /// <summary>
                /// display closing screen
                /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tThanks for Playing with Us Monsters.");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
                /// display continue prompt
                /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
                /// display header
                /// </summary>
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }
    }
}
