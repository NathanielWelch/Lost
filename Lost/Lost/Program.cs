using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Lost
{


    class Program
    {


        public static void Main(string[] args)
        {
            //Bring out your dead!!!

            //Looks like a ton of boolans for our sceens. Not sure why we are doing it this way. It works so don't touch it.
            bool mapMenu = false;
            bool inventory = false;
            bool status = false;
            bool townmenu = true;
            bool gamemenu = false;
            bool settings = false;
            bool about = false;
            bool armorshop = false;
            bool weaponshop = false;
            bool generalshop = false;
            //Got some Rando's here. Not sure where they will be used but this is where they go.

            int min;
            int max;

            //Here we got your basic RPG like stats.

            int lvl;
            int xp;
            int nextlvl;
            int gold;

            int maxHP;
            int nowHP;
            int maxMP;
            int nowMP;
            int maxSP;
            int nowSP;

            // Here's some more stats that will be used. Just putting them here real quick incase we start to bust that out...
            //UPDATE: To make it simple I'm going to only use the first 4 stats and see if I can make that work before I get to fancy.
            int str;
            int intel;
            int agi;
            int vital;

            int dex;
            int wisdom;
            int charm;
            int luck;

            int attack;
            int defense;
            int magicdmg;
            int magicdef;
            int dodge;
            int hit;
            int stamina;
            int fort;


            // Some basic Player information. Might be handled diffrently in the future when and if that whole system changes.
            string PlayerName;
            string PlayerSex;
            string PlayerAge;    //I had this as an INT but I can't figure out how to use try and catch blocks to verify the data type. So to make it simple I just made it a string.
            string PlayerClass;



            // Some general Navigation Strings I guess.

            string location;
            string discription;
            string time;

            PlayerClass = "";           //for some damn reason I have to have these there....i don't know why....LOST....But let's populate our default starting values.
            lvl = 1;
            maxHP = 10;
            nowHP = 10;
            maxMP = 0;
            nowMP = 0;
            maxSP = 10;
            nowSP = 10;

            nextlvl = 1000;
            xp = 654;
            gold = 100;
            location = "Town";
            discription = "The town that you woke up in.";
            time = "Morning";

            //Player equipment places

            string[] PlayerHead;
            string[] PlayerChest;
            string[] PlayerHands;
            string[] PlayerRing;
            string[] PlayerLegs;
            string[] PlayerFeet;
            string[] PlayerWeapon;



            int TotalSTR;
            int TotalAGI;
            int TotalINT;
            int TotalVIT;



            //Guess we need some starting arrays.


            //Here i guess is how I am going to do Items in this game. Arrays seem to work. There's probably a better way to do this. Not sure but it seems I can make this function
            //update added GP value to handle store stuff.
            //Weapons
            //name      disc             str  agi  int  vit  gp
            string[] stick = { "Stick", "A sharpend Stick", "2", "1", "0", "0", "5" };
            string[] club = { "Club", "A crude Club", "3", "2", "0", "0", "10" };
            string[] coppersword = { "Copper Sword", "A basic sword made of copper", "5", "3", "0", "0", "50" };
            string[] ironsword = { "Iron Sword", "A more refined balde", "6", "4", "0", "0", "100" };
            string[] steelsword = { "Steel Sword", "A tempered blade", "8", "6", "0", "0", "500" };
            string[] darkblade = { "A dark blade", "A blade of unknown origin", "10", "8", "0", "0", "1000" };

            //Head
            string[] clothcap = { "Cloth Cap", "A basic cloth cap", "0", "0", "0", "1", "5" };
            string[] leatherhelm = { "Leather Helm", "A sturdy Leather Helm", "1", "0", "0", "2", "10" };
            string[] copperhelm = { "Copper helm", "A copper Helm", "2", "0", "0", "0", "4", "20" };

            //Chest
            string[] clothshirt = { "Cloth Shirt", "A basic cloth shirt", "0", "0", "0", "1" };
            string[] leatherchest = { "Leather Chest Armor", "A sturdy Leather Chest Armor", "1", "0", "0", "2" };
            //Hands
            string[] clothgloves = { "Cloth Gloves", "Simple cloth gloves", "0", "0", "0", "1" };
            string[] leathergloves = { "Leather Gloves", "A pair of sturdy Leather Gloves", "1", "0", "0", "2" };

            //Ring
            string[] copperring = { "Copper Ring", "Simmple copper ring", "0", "0", "1", "1" };


            //Legs
            string[] clothpants = { "Cloth Pants", "Simple cloth pants", "0", "0", "0", "1" };
            string[] leatherpants = { "Leather Pants", "A pair of Sturdy Leather Pants", "1", "0", "0", "2" };

            //Feet
            string[] clothshoes = { "Cloth Shoes", "Simple cloth shoes", "0", "0", "0", "1" };
            string[] leatherboots = { "Leather Boots", "A pair of sturdy Leather Boots", "1", "0", "0", "2" };





            //Main Program Starts here moneky. 

            //Start up Screen. Would like to have the option to save a chractor and maybe have a new player intodiction screen. Going to have to figure out the menu system first.
            Console.BackgroundColor = ConsoleColor.Black; // Black background! What else. Might do a settings menu that will allow user to change colors but for now....
            Console.Clear(); //Clears the screen to return a screen with the new background color.
            Console.ForegroundColor = ConsoleColor.Green; //Changes the Foreground color to Green. Going for the monoschrome old school look here.
            //UPDATE: Definetly going to do a settings menu to change colors schemes. Prolly just pre make a few. Sound Player option to turn sound effects off.

            Console.Title = "LOST - Alpha Version 0.1 - www.NathanielWelch.org";   // Hey. I learned how to change the title bar. That's usefull... XD

            //
            //Took a quick look and figured how to add some sound. Note: Check the liscince on this track from opengameart.org. Gotta add it in a credits screen for any 
            //opensouce material I use.
            using (SoundPlayer player = new SoundPlayer("C:\\Users\\Public\\Music\\LostIntro.wav"))

            { player.Play(); }


            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("                                :XMMMMWx.                                                                ");
            Console.WriteLine("                                .xWMMMWl                                                                 ");
            Console.WriteLine("                                ; XMMMNl                                    .'..                         ");
            Console.WriteLine("                                 '0MMMWl                                    'ONKkl.                      ");
            Console.WriteLine("                                , KMMMWl            .'.             ...      cNMMW0,                    ");
            Console.WriteLine("                                , KMMMWo        'cx0XNXOo'      .;lk0XXk;    .kMMMWx.                   ");
            Console.WriteLine("                                , KMMMWo    .;oONMMMMMMMM0, .,lkKXNMMMMMNd.  .dMMMMk.                   ");
            Console.WriteLine("                                , KMMMWo   :0WMMXddXMMMMMWl.oWMMNl;xNMMMMK,  .xMMMMO;....,.              ");
            Console.WriteLine("                               .;xWMMMNc  .xMMMMK, oWMMMMX:.dWMMNl  ;0WNx,'oO0XMMMMWNNXNXO;              ");
            Console.WriteLine("                               .dNMMMMX:   oWMMMK, ,KMMMMNl.oWMMMXxc,:c' .lO00NMMMMNK000d'               ");
            Console.WriteLine("                                .kMMMMWx.  lWMMMK, '0MMMMK, ;kKWMMMMNKko;..  .xWMMMO'                   ");
            Console.WriteLine("                                 dMMMMWo   lWMMMK, '0MMMMO'   .;lkKWMMMMW0;   oWMMMO.                   ");
            Console.WriteLine("                                 dMMMMNc   lWMMMO. '0MMMM0'     .'';oXMMMMk.  lNMMMO.                   ");
            Console.WriteLine("                                 dMMMM0'   lWMMMk. ,KMMMM0'  .ckXk. .xMMMMO.  lNMMMO.                   ");
            Console.WriteLine("                                 oWMMMO.  .xWMMMXc.cXMMMMO. ;KWMMNx,.xMMMMO.  :XMMMO.                  ");
            Console.WriteLine("                                 lNMMM0'  .xWMMMMN0KWMWXk:  'kWMMMMX0XMMN0c.  ;XMMMO.                  ");
            Console.WriteLine("                                , KMMMNc   .cONMMMNOoc;.     .cONMMWN0dc'.    cNMMMO.                  ");
            Console.WriteLine("                                , KMMMX;      'clc'             'cl;'.   ..  .c0WMXc                  ");
            Console.WriteLine("                                 lNMMMXdloddol:;...                     'oo.   .;dOd.                 ");
            Console.WriteLine("                               .'c0MMMMMMMMMMMMMWNX0kxdo:'.             'o0d.                          ");
            Console.WriteLine("                              .lOXNX0xdlc::d0Oddddk0KNWMMWNKkoc..    .;dXKc.                          ");
            Console.WriteLine("                             .ckxo:,.               ...;:lxKWMMMX0OxlXWNx'                            ");
            Console.WriteLine("                              .,.                           .,lkXMMM0NWN0o,.                            ");
            Console.WriteLine("                                                              .:d0NWMXkc'.                              ");
            Console.WriteLine("                                                                                                        ");
            Console.WriteLine("                              A text adventure game by Nathaniel Jay Welch  Alpha Version 0.1           ");
            Console.WriteLine("                                                                                                        ");
            Console.SetCursorPosition(0, 28);
            Console.WriteLine("                                          --- Press any key to start the game --- ");
            Console.SetCursorPosition(81, 28);
            Console.ReadKey(); //wait for key press from the console.

            //Title screen is still missing something. Maybe a little 8 bit chip tune. Write that down....
            //UPDATE: Got the tune. Think it might be kinda anoying to have play the whole time. Might just play it during into and player creation.
            //Not sure how I would handle that if I do a player save/load thing thou. Kinda want the music to play out. Not nice to use it and not actully use it.)
            //Something I'll take care of when I get to it. Note the Nice ASCII artwork. Online generators are going to be my frined in this project.
            //The concpet around this project it useing the limited capabilities of a just console based application to still deliver a pleasent and 
            //immersive player expernaince.
            //New Player Screen I guess. Should be it's own thing once I figure out what I'm going to do about all that....
            //For now this will fill our charcter varibles up. Stats will be choosen on class value. Not really sure how to handle this.
            //Just going to prompt user for choices and comeback to a more custom player system.


            //New Player Creations Screen. Will Propably re-cycle into the About Screen/Menu. Maybe make this it's own menu. Create Char. Save. Load. etc. Help. New Player Info etc.
            //For now we are just going to ask some questions get out stuff and move on.
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("              ║ $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$¢$$$$$$$$$$$$$$$$$$$$$ ║");
            Console.WriteLine("              ║ $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$P,d$$$$$$$$$$$$$$$$$$$$$ ║");
            Console.WriteLine("              ║ $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$b,.`^²$$$$$$$$$$$$$$$$$$ ║");
            Console.WriteLine("              ║ $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ⁿ' ^~_ss$$$$$$$$$$$$$$$$$$$$$$$ ║");
            Console.WriteLine("              ║ $$$$$$$$$$l$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ẏbs,,.._```^'╜¢$$$$$$$$$$$$$$$$ ║");
            Console.WriteLine("              ║ $$$$$$$$$$:$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$P _.,sẏ$$$$$$$$$$$$$$$ ║");
            Console.WriteLine("              ║ $$$$$$$$s':╜,$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$¢$$$$$$$$$' `s$$$$$$$$$$$$$$$$$$$$$ ║");
            Console.WriteLine("              ║ $$$$$$$ys_  ,sl$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$P´   ``''ⁿ╜¢   d$$$$$$$$$$$$$$$$$$$$$ ║");
            Console.WriteLine("              ║ $$$$$$$¢P' ' ,:$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$P´ ,d.            ``^'²$$$$$$$$$$$$$$$$ ║");
            Console.WriteLine("              ║ $$$$$$╜ys, sdP ╜$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$P´                         ²$$$$$$$$$$$$$$ ║");
            Console.WriteLine("              ║ $$$$$$$$$$l$s, ',y$$$$$$$$$$$$$$$$$$$$$$$$$$$ẏs.                          ²$$$$$$$$$$$$$ ║");
            Console.WriteLine("              ║ $$l$$$l$$$:dy,  ,s$$$$l$$$$$$$$$$$$$$$$$$¢╜²'`      ,                   ` sẏ$$$$$$$$$$$$ ║");
            Console.WriteLine("              ║ $$:$$P:4$$ $$$ $$$$$$$:$$$$$$$$$$$$$$$$$Qẏẏs ss    ;$b                     `'ⁿ╜$$$$$$$$$ ║");
            Console.WriteLine("              ║ $l 'P  :$$ $$$:$$$$$$l l$²$$$$$$$$$$$$$$$$$$ $$    $$$                      .s$$$$$$$$$$ ║");
            Console.WriteLine("              ║ P   '   '╜ '╜¢l$$$$$²   ' '$$$$$$$$$$$$$$$$$:$$                           ` :$$$$$$$$$$$ ║");
            Console.WriteLine("              ╠══════════════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("              ║     You awaken. The pounding of your head lets you know instatly that your still alive.  ║");
            Console.WriteLine("              ║   You don't seem to recall anything. The bright light of the morning sun blinds you but  ║");
            Console.WriteLine("              ║   your vision soon adjusts. You can see a little old lady sitting in a rocking chair.    ║");
            Console.WriteLine("              ║   'We didn't think you were going to make it. You might not feel all that great, but     ║");
            Console.WriteLine("              ║    your alive.', she says as she slowly gets out of the rocking chair.                   ║");
            Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");
            Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("              ║                                                                                          ║");
            Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");

            //Ask for the Basics. Might have diffrent stuff based off baisc stats like this in the future but it's mostly filler right now.
            //UPDATE: Put some sort of story to the opening. General Idead is that you wake up. Don't really remember much. Your in this
            //area that is basicly cut off from the rest of the kingdom since the path out of the huge valley area collapsed.
            Console.SetCursorPosition(42, 28);
            Console.WriteLine("--- Press any key to continue --- ");
            Console.SetCursorPosition(75, 28);
            Console.ReadKey();
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("              ║      She leans of the dresser and sets down a key, 'We haven't had to many customers    ║");
            Console.WriteLine("              ║   since the collapse. You might as well stay here. Check with me later. I have some     ║");
            Console.WriteLine("              ║   things that still need to get done with the place. It's falling apart but it's been   ║");
            Console.WriteLine("              ║   here longer then me and might as well try and keep the place in serviceable shape.'   ║");
            Console.WriteLine("              ║                                                                                         ║");
            Console.SetCursorPosition(42, 28);
            Console.WriteLine("--- Press any key to continue --- ");
            Console.SetCursorPosition(75, 28);
            Console.ReadKey();
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("              ║                                                                                          ║");
            Console.WriteLine("              ║                                                                                          ║");
            Console.WriteLine("              ║     Well you don't happen to remember your name do you? Do you remember anything?        ║");
            Console.WriteLine("              ║                                                                                          ║");
            Console.WriteLine("              ║                                                                                          ║");
            Console.SetCursorPosition(17, 28);
            Console.WriteLine("Please enter your name:                                                        ");
            Console.SetCursorPosition(41, 28);
            PlayerName = Console.ReadLine();
            Console.SetCursorPosition(17, 28);
            Console.WriteLine("Please enter your sex. (M/F):                                                    ");
            Console.SetCursorPosition(47, 28);
            PlayerSex = Console.ReadLine();
            Console.SetCursorPosition(17, 28);
            Console.WriteLine("Please enter your age:                                                            ");
            Console.SetCursorPosition(40, 28);
            PlayerAge = Console.ReadLine();
            Console.SetCursorPosition(19, 10);


            //Here's a template for what a class starts with as far as stats go. Whys is there here. I don't know. See about doing something with this mess. You might need to get help.

            PlayerClass = "Warrior";
            maxHP = 20;
            nowHP = 20;
            maxMP = 5;
            nowMP = 5;
            str = 10;
            intel = 0;
            agi = 5;
            vital = 10;


            //I guess these would be the started inventory. Actully the first quest will involve getting these but for the sake of development we are just going to hand out this to start off.

            PlayerWeapon = stick;
            PlayerChest = clothshirt;
            PlayerHands = clothgloves;
            PlayerRing = copperring;
            PlayerLegs = clothpants;
            PlayerFeet = clothshoes;
            PlayerHead = clothcap;

            // Guess these will be some varibles to hold stat totals. Not sure how to go about this better. Good lord this is ugly. Hey it functions I think. We will see here in a bit.



            int weaponSTR = int.Parse(PlayerWeapon[2]);
            int headSTR = int.Parse(PlayerHead[2]);
            int chestSTR = int.Parse(PlayerChest[2]);
            int handSTR = int.Parse(PlayerHands[2]);
            int ringSTR = int.Parse(PlayerRing[2]);
            int legSTR = int.Parse(PlayerLegs[2]);
            int feetSTR = int.Parse(PlayerFeet[2]);
            TotalSTR = weaponSTR + headSTR + chestSTR + handSTR + ringSTR + legSTR + feetSTR + str;

            int weaponAGI = int.Parse(PlayerWeapon[3]);
            int headAGI = int.Parse(PlayerHead[3]);
            int chestAGI = int.Parse(PlayerChest[3]);
            int handAGI = int.Parse(PlayerHands[3]);
            int ringAGI = int.Parse(PlayerRing[3]);
            int legAGI = int.Parse(PlayerLegs[3]);
            int feetAGI = int.Parse(PlayerFeet[3]);
            TotalAGI = weaponAGI + headAGI + chestAGI + handAGI + ringAGI + legAGI + feetAGI + agi;

            int weaponINT = int.Parse(PlayerWeapon[4]);
            int headINT = int.Parse(PlayerHead[4]);
            int chestINT = int.Parse(PlayerChest[4]);
            int handINT = int.Parse(PlayerHands[4]);
            int ringINT = int.Parse(PlayerRing[4]);
            int legINT = int.Parse(PlayerLegs[4]);
            int feetINT = int.Parse(PlayerFeet[4]);
            TotalINT = weaponINT + headINT + chestINT + handINT + ringINT + legINT + feetINT + intel;

            int weaponVIT = int.Parse(PlayerWeapon[5]);
            int headVIT = int.Parse(PlayerHead[5]);
            int chestVIT = int.Parse(PlayerChest[5]);
            int handVIT = int.Parse(PlayerHands[5]);
            int ringVIT = int.Parse(PlayerRing[5]);
            int legVIT = int.Parse(PlayerLegs[5]);
            int feetVIT = int.Parse(PlayerFeet[5]);
            TotalVIT = weaponVIT + headVIT + chestVIT + handVIT + ringVIT + legVIT + feetVIT + vital;







            Console.SetCursorPosition(0, 20);
            Console.WriteLine("              ║        ALPHA: Class selection screen. Was going to do this right away but not sure       ║");
            Console.WriteLine("              ║    How I am going to handle combat etc for seperate classes.  So in Alpha everyone       ║");
            Console.WriteLine("              ║    will be  'Warrior' class. This is just to allow me to come up with the basic          ║");
            Console.WriteLine("              ║    combat etc.                                                                           ║");
            Console.WriteLine("              ║                                                                                          ║");
            Console.ReadKey();





            //Main Start Here kinda....I think.
            // I have this wierd boolan logic going on with this and it seems to work. I can perform action on the main menu that loops back but exit out to another loop menu.


            while (inventory)
            {
                inventory = InventoryMenu();
            }

            while (mapMenu)
            {
                mapMenu = MapMenu();
            }

            while (status)
            {
                status = StatusMenu();
            }

            while (townmenu)
            {
                townmenu = TownMenu();
            }

            while (gamemenu)
            {
                gamemenu = GameMenu();
            }

            while (settings)
            {
                settings = SettingsMenu();
            }

            while (about)
            {
                about = AboutMenu();
            }

            while (armorshop)
            {
                armorshop = ArmorShop();
            }

            while (weaponshop)
            {
                weaponshop = WeaponShop();
            }

            while (generalshop)
            {
                generalshop = GeneralShop();
            }

            // Game Menu - Default Menu Option Number 1

            bool GameMenu()
            {

                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║       Save Load etc. Basicly just a placeholder right now for the default menu options   ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");
                DefaultDisplayMenu();
                Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║    1. Return    2. Status    3. Inventory    4. Settings    A. About    X. Exit Game     ║");
                Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");

                //I know this is going to get messy. Going to have to do something to keep the formatting. Look into some tabular formating of something.
                DefaultDisplay(lvl, location, PlayerName, xp, nextlvl, discription, PlayerSex, nowHP, maxHP, time, PlayerAge, nowMP, maxMP, PlayerClass, nowSP, maxSP, gold);

                Console.SetCursorPosition(58, 24);

                switch (Console.ReadLine())
                {
                    case "1":
                        gamemenu = true;         // Return Option from Menu boolan to false and return fasle
                        return false;

                    case "2":
                        status = true;
                        StatusMenu();
                        return false;

                    case "3":
                        inventory = true;
                        InventoryMenu();
                        return false;

                    case "4":
                        settings = true;
                        SettingsMenu();
                        return false;

                    case "x":
                        Environment.Exit(0);
                        return false;

                    case "a":
                        about = true;
                        AboutMenu();
                        return false;

                    default:
                        return true;
                }
            }

            // Status Menu - Default Game Option 2

            bool StatusMenu()
            {
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("              ╔═══════════════════════════════╦══════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║  Stats                        ║  Equipment:                                              ║");
                Console.WriteLine("              ╠═══════════════════════════════╬══════════════════════════════════════════════════════════╣");
                Console.WriteLine("              ║                               ║                                                          ║");
                Console.WriteLine("              ║                Total  Base    ║                                                          ║");
                Console.WriteLine("              ║      Strength:                ║     Head:                                                ║");
                Console.WriteLine("              ║       Agility:                ║    Chest:                                                ║");
                Console.WriteLine("              ║  Intelligence:                ║    Hands:                                                ║");
                Console.WriteLine("              ║      Vitality:                ║     Ring:                                                ║");
                Console.WriteLine("              ║                               ║     Feet:                                                ║");
                Console.WriteLine("              ║                               ║   Weapon:                                                ║");
                Console.WriteLine("              ║                               ║                                                          ║");
                Console.WriteLine("              ║                               ║                                                          ║");
                Console.WriteLine("              ╚═══════════════════════════════╩══════════════════════════════════════════════════════════╝\n");
                DefaultDisplayMenu();
                Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║    1. Game      2. Return    3. Inventory   4. Settings    A. About    X. Exit Game      ║");
                Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");

                //I know this is going to get messy. Going to have to do something to keep the formatting. Look into some tabular formating of something.
                DefaultDisplay(lvl, location, PlayerName, xp, nextlvl, discription, PlayerSex, nowHP, maxHP, time, PlayerAge, nowMP, maxMP, PlayerClass, nowSP, maxSP, gold);
                Console.SetCursorPosition(32, 8); Console.WriteLine(TotalSTR);
                Console.SetCursorPosition(39, 8); Console.WriteLine(str);
                Console.SetCursorPosition(32, 9); Console.WriteLine(TotalAGI);
                Console.SetCursorPosition(39, 9); Console.WriteLine(agi);
                Console.SetCursorPosition(32, 10); Console.WriteLine(TotalINT);
                Console.SetCursorPosition(32, 11); Console.WriteLine(TotalVIT);
                Console.SetCursorPosition(58, 8); Console.WriteLine(PlayerHead[0]);
                Console.SetCursorPosition(72, 8); Console.WriteLine(PlayerHead[1]);
                Console.SetCursorPosition(58, 9); Console.WriteLine(PlayerChest[0]);
                Console.SetCursorPosition(72, 9); Console.WriteLine(PlayerChest[1]);
                Console.SetCursorPosition(58, 10); Console.WriteLine(PlayerHands[0]);
                Console.SetCursorPosition(72, 10); Console.WriteLine(PlayerHands[1]);
                Console.SetCursorPosition(58, 11); Console.WriteLine(PlayerRing[0]);
                Console.SetCursorPosition(72, 11); Console.WriteLine(PlayerRing[1]);
                Console.SetCursorPosition(58, 12); Console.WriteLine(PlayerFeet[0]);
                Console.SetCursorPosition(72, 12); Console.WriteLine(PlayerFeet[1]);
                Console.SetCursorPosition(58, 13); Console.WriteLine(PlayerWeapon[0]);
                Console.SetCursorPosition(72, 13); Console.WriteLine(PlayerWeapon[1]);
                switch (Console.ReadLine())
                {
                    case "1":
                        gamemenu = true;
                        GameMenu();
                        return false;

                    case "2":
                        status = false;      // Return Option from Menu boolan to false and return fasle
                        return false;

                    case "3":
                        inventory = true;
                        InventoryMenu();
                        return false;

                    case "4":
                        settings = true;
                        SettingsMenu();
                        return false;

                    case "x":
                        Environment.Exit(0);
                        return false;

                    case "a":
                        about = true;
                        AboutMenu();
                        return false;

                    default:
                        return true;
                }
            }

            // Inventory Menu. Default Menu Option 3

            bool InventoryMenu()
            {
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("              ╔═════════════════════════╦════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║    Item:                ║    Discription:                                                ║");
                Console.WriteLine("              ╠═════════════════════════╬════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("              ║                         ║                                                                ║");
                Console.WriteLine("              ║                         ║                                                                ║");
                Console.WriteLine("              ║                         ║                                                                ║");
                Console.WriteLine("              ║                         ║                                                                ║");
                Console.WriteLine("              ║                         ║                                                                ║");
                Console.WriteLine("              ║                         ║                                                                ║");
                Console.WriteLine("              ║                         ║                                                                ║");
                Console.WriteLine("              ║                         ║                                                                ║");
                Console.WriteLine("              ║                         ║                                                                ║");
                Console.WriteLine("              ║                         ║                                                                ║");
                Console.WriteLine("              ╚═════════════════════════╩════════════════════════════════════════════════════════════════╝\n");
                DefaultDisplayMenu();
                Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║      1. Game    2. Status    3. Return        4. Settings    A. About    X. Exit Game    ║");
                Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");

                //I know this is going to get messy. Going to have to do something to keep the formatting. Look into some tabular formating of something.
                DefaultDisplay(lvl, location, PlayerName, xp, nextlvl, discription, PlayerSex, nowHP, maxHP, time, PlayerAge, nowMP, maxMP, PlayerClass, nowSP, maxSP, gold);

                Console.SetCursorPosition(58, 24);

                switch (Console.ReadLine())
                {
                    case "1":
                        gamemenu = true;
                        GameMenu();
                        return false;

                    case "2":
                        status = true;
                        StatusMenu();
                        return false;

                    case "3":
                        inventory = false;  // Return Option from Menu boolan to false and return fasle
                        return false;

                    case "4":
                        settings = true;
                        SettingsMenu();
                        return false;

                    case "x":
                        Environment.Exit(0);
                        return false;

                    case "a":
                        about = true;
                        AboutMenu();
                        return false;

                    default:
                        return true;
                }
            }

            // Settings Menu - Default Menu Option 4.

            bool SettingsMenu()
            {

                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║       LOST - Game Settings Menu                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║       5. Green Monochrome Theme (Default)              S. Sound (OFF)                    ║");
                Console.WriteLine("              ║       6. Amber Monochrome Theme                                                          ║");
                Console.WriteLine("              ║       7. MS-DOS Theme                                                                    ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");
                DefaultDisplayMenu();
                Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║      1. Game    2. Status    3. Inventory    4. Return     A. About    X. Exit Game      ║");
                Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");

                //I know this is going to get messy. Going to have to do something to keep the formatting. Look into some tabular formating of something.
                DefaultDisplay(lvl, location, PlayerName, xp, nextlvl, discription, PlayerSex, nowHP, maxHP, time, PlayerAge, nowMP, maxMP, PlayerClass, nowSP, maxSP, gold);


                Console.SetCursorPosition(58, 24);

                switch (Console.ReadLine())
                {
                    case "1":
                        gamemenu = true;
                        GameMenu();
                        return true;

                    case "2":
                        status = true;
                        StatusMenu();
                        return true;

                    case "3":
                        inventory = true;
                        InventoryMenu();
                        return true;

                    case "4":
                        settings = false;       // Return Option from Menu boolan to false and return fasle
                        return false;


                    case "5":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Green;
                        return true;
                    case "6":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        return true;
                    case "7":
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        return true;



                    case "x":
                        Environment.Exit(0);
                        return false;

                    case "a":
                        about = true;
                        AboutMenu();
                        return true;

                    case "s":
                        using (SoundPlayer player = new SoundPlayer("C:\\Users\\Public\\Music\\LostIntro.wav"))

                        { player.Stop(); }

                        return true;

                    default:
                        return true;
                }
            }

            // About Menu - Default Menu Option 4.

            bool AboutMenu()
            {

                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                           About Lost: A Text Adventure Game                              ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║        LOST is a codeing project done in C# by Nathaniel Jay Welch while enrolled        ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║    at Independnce University in the BA program for Computer Software and Moblie          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║    Application Development.       (contact website etc.)                                 ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");
                DefaultDisplayMenu();
                Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║       1. Game   2. Status    3. Inventory   4. Settings    A. Return    X. Exit Game     ║");
                Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");

                //I know this is going to get messy. Going to have to do something to keep the formatting. Look into some tabular formating of something.
                DefaultDisplay(lvl, location, PlayerName, xp, nextlvl, discription, PlayerSex, nowHP, maxHP, time, PlayerAge, nowMP, maxMP, PlayerClass, nowSP, maxSP, gold);


                Console.SetCursorPosition(58, 24);

                switch (Console.ReadLine())
                {
                    case "1":
                        gamemenu = true;
                        GameMenu();
                        return true;

                    case "2":
                        status = true;
                        StatusMenu();
                        return true;

                    case "3":
                        inventory = true;
                        InventoryMenu();
                        return true;

                    case "4":
                        settings = true;
                        SettingsMenu();
                        return true;

                    case "x":
                        Environment.Exit(0);
                        return false;

                    case "a":
                        about = false;        // Return Option from Menu boolan to false and return fasle  
                        return false;


                    default:
                        return true;
                }
            }

            bool TownMenu()
            {
                location = "Town";
                discription = "The town that you woke up in.";
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║       This is the small town where you woke up at. They say nothing much has changed     ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║    since the collapse of the Great Pass. Besides a few shops the only busniess is the    ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║    local inn. It's not much but it's a place to recover and resupply for your travels.   ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║      (A)rmor Shop - To protect yourself          (I)nn - Get food and rest here          ║");
                Console.WriteLine("              ║      (W)eapon Shop - To arm yourself             (T)emple - Pray to the gods             ║");
                Console.WriteLine("              ║      (C)rafter's Hall - Learn to make stuff      (B)attle - Battle on the field          ║");
                Console.WriteLine("              ║      (G)eneral Store - Buy the basics            (M)ap - Look at your map                ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");
                DefaultDisplayMenu();
                OptionsMenu();
                //I know this is going to get messy. Going to have to do something to keep the formatting. Look into some tabular formating of something.

                DefaultDisplay(lvl, location, PlayerName, xp, nextlvl, discription, PlayerSex, nowHP, maxHP, time, PlayerAge, nowMP, maxMP, PlayerClass, nowSP, maxSP, gold);


                Console.SetCursorPosition(58, 24);

                switch (Console.ReadLine())
                {
                    case "1":
                        gamemenu = true;
                        GameMenu();
                        return true;

                    case "2":
                        status = true;
                        StatusMenu();
                        return true;

                    case "3":
                        inventory = true;
                        InventoryMenu();
                        return true;

                    case "4":
                        settings = true;
                        SettingsMenu();
                        return true;

                    case "x":
                        Environment.Exit(0);
                        return false;

                    case "h":
                        about = true;
                        AboutMenu();
                        return true;

                    case "a":
                        armorshop = true;
                        ArmorShop();
                        return true;

                    case "w":
                        weaponshop = true;
                        WeaponShop();
                        return true;

                    case "g":
                        generalshop = true;
                        GeneralShop();
                        return true;

                    case "m":
                        mapMenu = true;
                        MapMenu();
                        return true;

                    default:
                        return true;
                }
            }

            bool ArmorShop()
            {
                location = "Town Armor Shop";
                discription = "An armor shop run by an old blacksmith.";
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║    Armor Shop                                                                            ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║      (B)uy - Buy Item from List                                                          ║");
                Console.WriteLine("              ║      (S)ell - Sell item you have                                                         ║");
                Console.WriteLine("              ║      (G)oodbye - Leave Store                                                             ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");
                DefaultDisplayMenu();
                OptionsMenu();

                //I know this is going to get messy. Going to have to do something to keep the formatting. Look into some tabular formating of something.

                DefaultDisplay(lvl, location, PlayerName, xp, nextlvl, discription, PlayerSex, nowHP, maxHP, time, PlayerAge, nowMP, maxMP, PlayerClass, nowSP, maxSP, gold);


                Console.SetCursorPosition(58, 24);

                switch (Console.ReadLine())
                {
                    case "1":
                        gamemenu = true;
                        GameMenu();
                        return true;

                    case "2":
                        status = true;
                        StatusMenu();
                        return true;

                    case "3":
                        inventory = true;
                        InventoryMenu();
                        return true;

                    case "4":
                        settings = true;
                        SettingsMenu();
                        return true;

                    case "x":
                        Environment.Exit(0);
                        return false;

                    case "a":
                        about = true;
                        AboutMenu();
                        return true;

                    case "g":
                        townmenu = true;
                        TownMenu();
                        return true;

                    default:
                        return true;
                }
            }

            //Shop Meathods. Not sure how I'm going to handle what's avaliable based on diffrent classes. this is just to get a functioning way to upgrade gear.
            //Don't really like useing GOLD as a gateing method but hey it's worked in many a RPG. I'm don't have to make anything new...Just not yet at least.
            //Maybe do some ascii art here to make the shops look a little diffrent. Not sure if I should have a sell option. Kinda don't like the way I'm handleing inventory.


            bool WeaponShop()
            {
                location = "Town Weapon Shop";
                discription = "An Weapon shop run by a retired soilder.";
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║    Weapon Shop                           1. Stick                                        ║");
                Console.WriteLine("              ║                                          2. Club                                         ║");
                Console.WriteLine("              ║                                          3. Copper Sword                                 ║");
                Console.WriteLine("              ║                                          4. Iron Sword                                   ║");
                Console.WriteLine("              ║                                          5. Steel Sword                                  ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║      (B)uy - Buy Item from List                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║      (G)oodbye - Leave Store                                                             ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");
                DefaultDisplayMenu();
                OptionsMenu();

                //I know this is going to get messy. Going to have to do something to keep the formatting. Look into some tabular formating of something.
                //UPDATE Well I put this into it's own method. This seems to work to some extent to reduce the amount of code.
                DefaultDisplay(lvl, location, PlayerName, xp, nextlvl, discription, PlayerSex, nowHP, maxHP, time, PlayerAge, nowMP, maxMP, PlayerClass, nowSP, maxSP, gold);


                Console.SetCursorPosition(58, 24);

                switch (Console.ReadLine())
                {
                    case "1":
                        gamemenu = true;
                        GameMenu();
                        return true;

                    case "2":
                        status = true;
                        StatusMenu();
                        return true;

                    case "3":
                        inventory = true;
                        InventoryMenu();
                        return true;

                    case "4":
                        settings = true;
                        SettingsMenu();
                        return true;

                    case "b":
                        WeaponBuy();
                        return true;

                    case "x":
                        Environment.Exit(0);
                        return false;

                    case "a":
                        about = true;
                        AboutMenu();
                        return true;

                    case "g":
                        townmenu = true;
                        TownMenu();
                        return true;

                    default:
                        return true;
                }
            }

            bool GeneralShop()
            {
                location = "Town's General Store";
                discription = "The old General Store in town.";
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║    General Store                                                                         ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║      (B)uy - Buy Item from List                                                          ║");
                Console.WriteLine("              ║      (S)ell - Sell item you have                                                         ║");
                Console.WriteLine("              ║      (G)oodbye - Leave Store                                                             ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");
                DefaultDisplayMenu();
                OptionsMenu();

                //I know this is going to get messy. Going to have to do something to keep the formatting. Look into some tabular formating of something.

                DefaultDisplay(lvl, location, PlayerName, xp, nextlvl, discription, PlayerSex, nowHP, maxHP, time, PlayerAge, nowMP, maxMP, PlayerClass, nowSP, maxSP, gold);


                Console.SetCursorPosition(58, 24);

                switch (Console.ReadLine())
                {
                    case "1":
                        gamemenu = true;
                        GameMenu();
                        return true;

                    case "2":
                        status = true;
                        StatusMenu();
                        return true;

                    case "3":
                        inventory = true;
                        InventoryMenu();
                        return true;

                    case "4":
                        settings = true;
                        SettingsMenu();
                        return true;

                    case "x":
                        Environment.Exit(0);
                        return false;

                    case "a":
                        about = true;
                        AboutMenu();
                        return true;

                    case "g":
                        townmenu = true;
                        TownMenu();
                        return true;

                    default:
                        return true;
                }
            }
            bool MapMenu()
            {
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║       There isn't many places to travel since the Great Pass collapsed. There are        ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║    still some places left that can be accesed. You look at your map. You have the        ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║    locations that you know marked on your map.  (locations hard coded in alpha)          ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ║      (B)each - The beachs west of town           (K)ingdom Outpost - The last outpost    ║");
                Console.WriteLine("              ║      (W)oodlands - The woodlands east of town    (T)own - Your small hometown            ║");
                Console.WriteLine("              ║      (C)aves - The caves north of town           (G)uild Hall - Your class guild hall    ║");
                Console.WriteLine("              ║      (F)ields - The fields south of town         (M)arket Place - Random goods for sale  ║");
                Console.WriteLine("              ║                                                                                          ║");
                Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");
                DefaultDisplayMenu();
                OptionsMenu();

                //I know this is going to get messy. Going to have to do something to keep the formatting. Look into some tabular formating of something.
                DefaultDisplay(lvl, location, PlayerName, xp, nextlvl, discription, PlayerSex, nowHP, maxHP, time, PlayerAge, nowMP, maxMP, PlayerClass, nowSP, maxSP, gold);

                Console.SetCursorPosition(58, 24);

                switch (Console.ReadLine())
                {
                    case "1":
                        gamemenu = true;
                        GameMenu();
                        return true;

                    case "2":
                        status = true;
                        StatusMenu();
                        return false;

                    case "3":
                        inventory = true;
                        InventoryMenu();
                        return false;

                    case "t":
                        townmenu = true;
                        TownMenu();
                        return false;


                    case "x":
                        Environment.Exit(0);
                        return false;

                    default:
                        return true;
                }
            }

            bool WeaponBuy()
            {
                Console.SetCursorPosition(35, 24);
                Console.WriteLine("What Item would you like to buy?           ");


                switch (Console.ReadLine())
                {
                    case "1":

                        int value = int.Parse(PlayerWeapon[6]);
                        int sell = value / 2;
                        Console.SetCursorPosition(35, 24);
                        Console.WriteLine($"Sold your {PlayerWeapon[0]} for {sell} GP.            ");
                        Console.SetCursorPosition(35, 24);
                        Console.ReadKey();
                        int transaction;
                        transaction = sell + gold;
                        gold = transaction;
                        PlayerWeapon = stick;
                        Console.SetCursorPosition(35, 24);
                        int price = int.Parse(stick[6]);
                        gold = gold - price;
                        Console.WriteLine($"You now have {PlayerWeapon[0]}        ");
                        Console.SetCursorPosition(35, 24);
                        Console.ReadKey();
                        Console.SetCursorPosition(35, 24);
                        Console.WriteLine("--- Press any key to continue ---          ");
                        Console.SetCursorPosition(46, 24);
                        Console.ReadKey();
                        weaponshop = true;
                        return true;

                    default:

                        return true;

                }



                return true;
            }




        }


        //Here I put my default stats display into it's own meathod instead of haveing this hardcoded to every menu. I inmagine I will streamline everything once i have the framework.
        //All my menu subsection might be handled in a simular way or maybe diffrently. This is still going to be a big mess trying to figure out how to keep formating when values scale.
        //Currently I just have the justified next to the label that hard coded right now.

        public static void OptionsMenu()
        {
            Console.SetCursorPosition(0, 27);
            Console.WriteLine("              ╔══════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("              ║     1. Game     2. Status    3. Inventory   4. Settings    A. About    X. Exit Game      ║");
            Console.WriteLine("              ╚══════════════════════════════════════════════════════════════════════════════════════════╝\n");
        }
        public static void DefaultDisplayMenu()
        {
            Console.SetCursorPosition(0, 18);
            Console.WriteLine("              ╔══════════════════╦═══════════════════════════════════════════════╦═══════════════════════╗");
            Console.WriteLine("              ║  LVL:            ║  Location:                                    ║    Name:              ║");
            Console.WriteLine("              ║  EXP:            ║  Discription:                                 ║     Sex:              ║");
            Console.WriteLine("              ║   HP:            ║  Time:                                        ║     Age:              ║");
            Console.WriteLine("              ║   MP:            ║                                               ║   Class:              ║");
            Console.WriteLine("              ║   SP:            ╠═══════════════════════════════════════════════╩═══════════════════════╣");
            Console.WriteLine("              ║   GP:            ║  Please Make a Choice:                                                ║");
            Console.WriteLine("              ╚══════════════════╩═══════════════════════════════════════════════════════════════════════╝\n");
        }
        public static void DefaultDisplay(int lvl, string location, string PlayerName, int xp, int nextlvl, string discription, string PlayerSex, int nowHP, int maxHP, string time, string PlayerAge, int nowMP, int maxMP, string PlayerClass, int nowSP, int maxSP, int gold)
        {
            Console.SetCursorPosition(23, 19); Console.WriteLine(lvl);
            Console.SetCursorPosition(46, 19); Console.WriteLine(location);
            Console.SetCursorPosition(92, 19); Console.WriteLine(PlayerName);
            Console.SetCursorPosition(23, 20); Console.WriteLine(xp + "/" + nextlvl);
            Console.SetCursorPosition(49, 20); Console.WriteLine(discription);
            Console.SetCursorPosition(92, 20); Console.WriteLine(PlayerSex);
            Console.SetCursorPosition(23, 21); Console.WriteLine(nowHP + "/" + maxHP);
            Console.SetCursorPosition(42, 21); Console.WriteLine(time);
            Console.SetCursorPosition(92, 21); Console.WriteLine(PlayerAge);
            Console.SetCursorPosition(23, 22); Console.WriteLine(nowMP + "/" + maxMP);
            Console.SetCursorPosition(92, 22); Console.WriteLine(PlayerClass);
            Console.SetCursorPosition(23, 23); Console.WriteLine(nowSP + "/" + maxSP);
            Console.SetCursorPosition(23, 24); Console.WriteLine(gold);

        }



        //I guess here I have some random meathods going on. Before  I get to far I will try and make sure all the places are set.

        //default class for random numbers i think....that was on day 1 and who knows what i was orginaly going to do with it.
        public static Random _random = new Random();

        public static void LookAround()
        {
            int luck;

            Console.SetCursorPosition(59, 25);
            Console.WriteLine("You look around");
            luck = RandomSmall();
            Console.SetCursorPosition(20, 10);
            Console.WriteLine($"You rolled a {luck} for luck.");

            SmallChest(luck);








        }







        public static void SmallChest(int luck)
        {
            Console.SetCursorPosition(20, 11);
            if (luck > 7)
            {
                Console.WriteLine("You found a chest with 30 GP in it!");
            }

            if (luck > 4 && luck < 8)
            {
                Console.WriteLine("Your found a chest with 20 GP in it!");
            }

            if (luck > 0 && luck < 5)
            {
                Console.WriteLine("You found a chest but it was empty!");
            }


        }






        public static int RandomSmall()
        {
            return _random.Next(1, 10);

        }

    }
}
