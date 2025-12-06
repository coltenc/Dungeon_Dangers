//booleans
using System.Reflection.Metadata.Ecma335;
using System.Xml;

bool mainmenu = true;
bool Backenterance = true;
bool enter = true;
bool chestopen = false;
bool dooropen = false;
bool dragondefeat = false;
bool investigated = false;
bool sword = false;
bool hatch = false;
//ints
int MMenu = 1;
int roomselection = 0;
int KeyDoor = 0;
int selector = 0;
int nextroom = 0;
int inventory = 0;
int hall = 0;

do
{
    Console.Clear();

    // play menu
    if(MMenu == 1)
    {
        mainmenuPlay();

        ConsoleKeyInfo key = Console.ReadKey(true);

        switch (key.Key)
        {
            case ConsoleKey.S:
            MMenu = 2;
            Console.Clear();
            break;

            case ConsoleKey.Enter:
            mainmenu = false;
            Console.Clear();
            break;

            default:
            Console.Clear();
            break;
        }
    }

//return menu
    if(MMenu == 2)
    {
        mainmenuReturn();

        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.W:
            MMenu = 1;
            Console.Clear();
            break;

            case ConsoleKey.S:
            MMenu = 3;
            Console.Clear();
            break;

            case ConsoleKey.Enter:
            mainmenu = false;
            Console.Clear();
            break;

            default:
            Console.Clear();
            break;
        }
    }

//exit menu
    if(MMenu == 3)
    {
        mainmenuExit();

        ConsoleKeyInfo key = Console.ReadKey(true);

        switch (key.Key)
        {
            case ConsoleKey.W:
            MMenu = 2;
            Console.Clear();
            break;

            case ConsoleKey.Enter:
            Console.Clear();
            Console.WriteLine("Bye.....");
            Environment.Exit(0);
            break;

            default:
            Console.Clear();
            break;
        }
    }
}while(mainmenu == true);


//game its self
do
{
    //enterance halls
    while(enter == true)
    {
        enterance();
        inventoryCode();
        Console.WriteLine();
        roomselection = Convert.ToInt32(Console.ReadLine());
        enter = false;
        Console.Clear();
        if(roomselection > 3)
        {
            enter = true;
            Console.Clear();
        }
    }


//First room
    if(roomselection == 1)
    {
        roomselection =0;

        if(chestopen == true)
        {

            firstroomOpen();
            inventoryCode();
            selector = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (selector)
            {
                case 1:
                enter = true;
                Console.Clear();
                break;

                default:
                break;
            }
        }
        else
        {
            firstroom();
            inventoryCode();
            Console.WriteLine();
            selector = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (selector)
            {
                case 1:
                enter = true;
                Console.Clear();
                break;

                case 2:
                KeyDoor = 1;
                chestopen = true;
                nextroom = 1;
                inventory = 1;
                Console.Clear();
                break;

                default:
                roomselection = 1;
                Console.Clear();
                break;
            }
        }
    }

//second room
    if(roomselection == 2)
    {
        roomselection =0;

        if(dooropen == true)
        {
            secondroomDoorOpen();
            inventoryCode();
            selector = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (selector)
            {
                case 1:
                enter = true;
                Console.Clear();
                break;

                case 2:
                nextroom = 2;
                Console.Clear();
                break;

                default:
                break;
            }
        }
        else
        {
            secondroom();
            inventoryCode();
            selector = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (selector)
            {
                case 1:
                enter = true;
                break;

                case 2:
                if(KeyDoor == 1)
                    {
                       nextroom = 2;
                       dooropen = true;
                    }
                    else
                    {
                        nextroom = 3;
                    }
                break;

                default:
                roomselection = 2;
                Console.Clear();
                break;
            }
        }
    }

//third room
    if(roomselection == 3)
    {
        roomselection =0;

        thirdroom();
        inventoryCode();
        selector = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (selector)
            {
                case 1:
                enter = true;
                break;

                default:
                roomselection = 3;
                Console.Clear();
                break;
            }
    }

//first hallway
    if(hall == 1)
    {
        save();
        FirstHall();
        inventoryCode();
        roomselection = Convert.ToInt32(Console.ReadLine());
        hall = 0;
        if(roomselection == 1)
            {
                roomselection = 5;
            }
        if(roomselection == 2)
            {
              roomselection = 4;  
            }
        if(roomselection > 2)
            {
                hall = 1;
                Console.Clear();
            }
        Console.Clear();
    }

//forth room
    if(roomselection == 4)
    {
        if(hatch == true)
        {
            nextroom = 5;
        }
        else
        {
            forthroom();
            inventoryCode();
            selector = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (selector)
            {
                case 1:
                hall = 1;
                Console.Clear();
                break;

                case 2:
                investigated = true;
                sword = true;
                inventory2();
                nextroom = 4;
                Console.Clear();
                break;

                default:
                roomselection = 4;
                Console.Clear();
                break;
            }
            
        }
    }

//fifth room
    if(roomselection == 5)
    {
        if(dragondefeat == true)
        {
            nextroom = 4;
        }
        else
        {
            fifthroom();
            inventoryCode();
            selector = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (selector)
            {
                case 1:
                hall = 1;
                Console.Clear();
                break;

                case 2:
                if(sword == true)
                    {
                        nextroom = 6;
                    }
                else
                    {
                        nextroom = 7;
                    }
                Console.Clear();
                break;

                default:
                roomselection = 5;
                Console.Clear();
                break;
            }
        }
    }



// rooms extended
//first room (chest opened).
    if(nextroom == 1)
    {
        nextroom =0;

        firstroomOpen();
        inventoryCode();
        selector = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (selector)
        {
            case 1:
            enter = true;
            Console.Clear();
            break;

            default:
            nextroom = 1;
            Console.Clear();
            break;
        }
    }

//second room (door opened).
    if(nextroom == 2)
    {
        nextroom =0;
        
        secondroomDoorOpen();
        inventoryCode();
        selector = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (selector)
        {
            case 1:
            enter = true;
            Console.Clear();
            break;

            case 2:
            hall = 1;
            Console.Clear();
            break;

            default:
            nextroom = 2;
            Console.Clear();
            break;
        }
    }

//second room failed
    if(nextroom == 3)
         {
            nextroom =0;
        
            secondroomDoorFail();
            inventoryCode();
            selector = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

        switch (selector)
        {
            case 1:
            enter = true;
            Console.Clear();
            break;

            default:
            nextroom = 3;
            Console.Clear();
            break;
        }
    }

//forth room investigated
if(nextroom == 4)
    {
        nextroom = 0;

        forthroomInvestigated();
        selector = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (selector)
        {
            case 1:
            hall = 1;
            Console.Clear();
            break;

            case 2:
            nextroom = 5;
            break;

            default:
            nextroom = 4;
            Console.Clear();
            break;
        }
    }

//forth room inside  room
if(nextroom == 5)
    {
        nextroom = 0;
        roomselection = 0;
        hatch = true;
        Console.Clear();

        forthroominside();
        inventoryCode();

        selector = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (selector)
        {
            case 1:
            hall = 1;
            Console.Clear();
            break;

            case 2:
            nextroom = 8;
            Console.Clear();
            break;

            default:
            nextroom = 5;
            Console.Clear();
            break;
        }
    }

//forth room picked up sword
if(nextroom == 8)
    {
        nextroom = 0;
        sword = true;
        inventory = 2;

        forthroomNoSword();
        inventoryCode();
        selector = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (selector)
        {
            case 1:
            hall = 1;
            Console.Clear();
            break;

            default:
            nextroom = 8;
            Console.Clear();
            break;
        }
    }

//fifth dragon defeated
if(nextroom == 6)
    {
        nextroom = 0;

        fifthroomDefeat();
        inventoryCode();
        selector = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (selector)
        {
            case 1:
            nextroom = 9;
            Console.Clear();
            break;

            default:
            nextroom = 6;
            Console.Clear();
            break;
        }
    }

//fifthroom dragon fail
if(nextroom == 7)
    {
        nextroom = 0;

        fifthroomFail();
        inventoryCode();
        selector = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (selector)
        {
            case 1:
            hall = 1;
            Console.Clear();
            break;

            default:
            nextroom = 7;
            Console.Clear();
            break;
        }
    }

//congradulations you beat the game
if(nextroom == 9)
    {
        nextroom = 0;
        congradulations();
        selector = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        ConsoleKeyInfo key = Console.ReadKey(true);

        switch (key.Key)
        {

            case ConsoleKey.Enter:
            Environment.Exit(0);
            Console.Clear();
            break;

            default:
            nextroom = 9;
            Console.Clear();
            break;
        }

    }

}while(Backenterance == true);


//save code
void save()
{
    string filename = "save.csv";
    string line = $"Inventory,{inventory}";
    File.WriteAllText(filename, line);
}

//mainmenu
void mainmenuPlay()
{
    Console.WriteLine("_____________________");
    Console.WriteLine("| Dungeon of dangers|");
    Console.WriteLine("|                   |");
    Console.WriteLine("|      |Play|       |");
    Console.WriteLine("|      Return       |");
    Console.WriteLine("|       Exit        |");
    Console.WriteLine("|___________________|");
}
void mainmenuReturn()
{
    
    Console.WriteLine("_____________________");
    Console.WriteLine("| Dungeon of dangers|");
    Console.WriteLine("|                   |");
    Console.WriteLine("|       Play        |");
    Console.WriteLine("|     |Return|      |");
    Console.WriteLine("|       Exit        |");
    Console.WriteLine("|___________________|");
}

void mainmenuExit()
{
    Console.WriteLine("_____________________");
    Console.WriteLine("| Dungeon of dangers|");
    Console.WriteLine("|                   |");
    Console.WriteLine("|       Play        |");
    Console.WriteLine("|      Return       |");
    Console.WriteLine("|      |Exit|       |");
    Console.WriteLine("|___________________|");
}

//rooms
void enterance()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|    |         |         |            |          |             |     |           __________________________________________________________________________");
    Console.WriteLine("|    |         |         |            |          |             |     |           |   You have enter the dungeon and found 3 paths which path do you choose |");
    Console.WriteLine("|    |         |         |            |          |             |     |           |                                                                         |");
    Console.WriteLine("|    |         |         |            |          |             |     |           |                   1- The left path                                      |");
    Console.WriteLine("|    |         |         |            |          |             |     |           |                   2- The middle path                                    |");
    Console.WriteLine("|    |         |         |            |          |             |     |           |                   3- The Right Path                                     |");
    Console.WriteLine("|    |         |         |            |          |             |     |           |_________________________________________________________________________|");
    Console.WriteLine("|    |         |         |            |          |             |     |");
    Console.WriteLine("|    |         |         |            |          |             |     |");
    Console.WriteLine("|____|         |_________|            |__________|             |_____|");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                       |                    |                       |");
    Console.WriteLine("|                       |                    |                       |");
    Console.WriteLine("|_______________________|                    |_______________________|");
}

//base rooms
void firstroom()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|                                                                    |           _______________________________________________________________");
    Console.WriteLine("|                             _____                                  |           |   You found a chest in the room what would you like to do   |");
    Console.WriteLine("|                            |  _  |                                 |           |                                                             |");
    Console.WriteLine("|                            | |_| |                                 |           |                  1- back                                    |");
    Console.WriteLine("|                            |_____|                                 |           |                  2- Open the chest                          |");
    Console.WriteLine("|                                                                    |           |                                                             |");
    Console.WriteLine("|                                                                    |           |_____________________________________________________________|");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|_______________________|                    |_______________________|");
}
 
void secondroom()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|                                                                    |           ______________________________________________________");
    Console.WriteLine("|                 _____________________                              |           |   You have found a door that needs a key to open!  |");
    Console.WriteLine("|                 |                    |                             |           |                                                    |");
    Console.WriteLine("|                 |                    |                             |           |                1- Back                             |");
    Console.WriteLine("|                 |                    |                             |           |                2- Open The door                    |");
    Console.WriteLine("|                 |              ____  |                             |           |                                                    |");
    Console.WriteLine("|                 |              |  |  |                             |           |____________________________________________________|");
    Console.WriteLine("|                 |              |__|  |                             |");
    Console.WriteLine("|                 |                    |                             |");
    Console.WriteLine("|                 |                    |                             |");
    Console.WriteLine("|                 |____________________|                             |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|_______________________|                    |_______________________|");   
}

void thirdroom()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|                                                                    |           ______________________________");
    Console.WriteLine("|                                                                    |           |   You found a empty room   |");
    Console.WriteLine("|                                                                    |           |                            |");
    Console.WriteLine("|                                                                    |           |       1- Back              |");
    Console.WriteLine("|                                                                    |           |                            |");
    Console.WriteLine("|                                                                    |           |                            |");
    Console.WriteLine("|                                                                    |           |____________________________|");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|_______________________|                    |_______________________|");   
}

void FirstHall()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|          |              |              |                |          |           ______________________________________________________________________");
    Console.WriteLine("|          |              |              |                |          |           |   You have reached some cross hairs which path should you choose   |");
    Console.WriteLine("|          |              |              |                |          |           |                                                                    |");
    Console.WriteLine("|          |              |              |                |          |           |                1- Left Path                                        |");
    Console.WriteLine("|          |              |              |                |          |           |                2- Right Path                                       |");
    Console.WriteLine("|          |              |              |                |          |           |                                                                    |");
    Console.WriteLine("|          |              |              |                |          |           |____________________________________________________________________|");
    Console.WriteLine("|          |              |              |                |          |");
    Console.WriteLine("|__________|              |______________|                |__________|");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|_______________________|                    |_______________________|");   
}

void forthroom()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|                                                                    |           ___________________________________________________");
    Console.WriteLine("|                                                                    |           |   You have stepped into a normal looking room   |");
    Console.WriteLine("|                                                                    |           |                                                 |");
    Console.WriteLine("|                                                                    |           |             1- Back                             |");
    Console.WriteLine("|                                                                    |           |             2- Investigate room                 |");
    Console.WriteLine("|                                                                    |           |                                                 |");
    Console.WriteLine("|                                                                    |           |_________________________________________________|");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|_______________________|                    |_______________________|");   
}

void fifthroom()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|                                                                    |           _______________________________");
    Console.WriteLine("|                                                                    |           |   You have found a dragon   |");
    Console.WriteLine("|                                                                    |           |                             |");
    Console.WriteLine("|                            ______________                          |           |     1- Back                 |");
    Console.WriteLine("|                           |    _    _    |                         |           |     2- Fight the dragon     |");
    Console.WriteLine("|                           |   |_|  |_|   |                         |           |                             |");
    Console.WriteLine("|                           |    ______    |                         |           |_____________________________|");
    Console.WriteLine("|                           |   |______|   |                         |");
    Console.WriteLine("|                           |______________|                         |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|_______________________|                    |_______________________|");   
}


//open room rooms.
void firstroomOpen()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|                                                                    |           _________________________________________________");
    Console.WriteLine("|                             _____                                  |           |   You found a key would would you like to do   |");
    Console.WriteLine("|                            |     |                                 |           |                                                |");
    Console.WriteLine("|                            |     |                                 |           |             1- go to enterance                 |");
    Console.WriteLine("|                            |_____|                                 |           |                                                |");
    Console.WriteLine("|                                                                    |           |                                                |");
    Console.WriteLine("|                                                                    |           |________________________________________________|");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|_______________________|                    |_______________________|");
}

void secondroomDoorFail()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|                                                                    |           ______________________________________________");
    Console.WriteLine("|                 _____________________                              |           |   Sorry you need a key to open the door!   |");
    Console.WriteLine("|                 |                    |                             |           |                                            |");
    Console.WriteLine("|                 |                    |                             |           |          1- Back                           |");
    Console.WriteLine("|                 |                    |                             |           |                                            |");
    Console.WriteLine("|                 |              ____  |                             |           |                                            |"); 
    Console.WriteLine("|                 |              |  |  |                             |           |____________________________________________|");
    Console.WriteLine("|                 |              |__|  |                             |");
    Console.WriteLine("|                 |                    |                             |");
    Console.WriteLine("|                 |                    |                             |");
    Console.WriteLine("|                 |____________________|                             |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|_______________________|                    |_______________________|");   
}

void secondroomDoorOpen()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|                                                                    |           _________________________________________");
    Console.WriteLine("|                 _____________________                              |           |   Congradulations the door opened!!   |");
    Console.WriteLine("|                 |                    |                             |           |                                       |");
    Console.WriteLine("|                 |                    |                             |           |       1- Back                         |");
    Console.WriteLine("|                 |                    |                             |           |       2- Go in the door               |");
    Console.WriteLine("|                 |                    |                             |           |                                       |");
    Console.WriteLine("|                 |                    |                             |           |_______________________________________|");
    Console.WriteLine("|                 |                    |                             |");
    Console.WriteLine("|                 |                    |                             |");
    Console.WriteLine("|                 |                    |                             |");
    Console.WriteLine("|                 |____________________|                             |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|_______________________|                    |_______________________|");   
}

void forthroomInvestigated()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|                                                                    |           ___________________________________________________");
    Console.WriteLine("|                                                                    |           |   You Investigated the room and found a hatch   |");
    Console.WriteLine("|                                                                    |           |                                                 |");
    Console.WriteLine("|                                                                    |           |             1- Back                             |");
    Console.WriteLine("|                                                                    |           |             2- Open hatch                       |");
    Console.WriteLine("|                                                                    |           |                                                 |");
    Console.WriteLine("|                       ___________________                          |           |_________________________________________________|");
    Console.WriteLine("|                      |              /    |                         |");
    Console.WriteLine("|                      |            /      |                         |");
    Console.WriteLine("|                      |          /       /|                         |");
    Console.WriteLine("|                      |        /       /  |                         |");
    Console.WriteLine("|                      |      /       /    |                         |");
    Console.WriteLine("|                      |    /       /      |                         |");
    Console.WriteLine("|                      |  /       /        |                         |");
    Console.WriteLine("|                      |/_______/__________|                         |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|_______________________|                    |_______________________|");   
}

void forthroominside()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|                                                                    |           ______________________________");
    Console.WriteLine("|                                                                    |           |   You have found a sword   |");
    Console.WriteLine("|                             _                                      |           |                            |");
    Console.WriteLine("|                            |0|                                     |           |      1- Back               |");
    Console.WriteLine("|                            |=|                                     |           |      2- Pickup Sword       |");
    Console.WriteLine("|                          __|_|__                                   |           |                            |");
    Console.WriteLine("|                    0|====|  |  |====|0                             |           |____________________________|");
    Console.WriteLine("|                          |  |  |                                   |");
    Console.WriteLine("|                          |  |  |                                   |");
    Console.WriteLine("|                          |  |  |                                   |");
    Console.WriteLine("|                          |  |  |                                   |");
    Console.WriteLine("|                      oooooooooooooo                                |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|_______________________|                    |_______________________|");   
}

void forthroomNoSword()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|                                                                    |           ________________________________");
    Console.WriteLine("|                                                                    |           |   You picked up the sword    |");
    Console.WriteLine("|                                                                    |           |                              |");
    Console.WriteLine("|                                                                    |           |         1-Exit               |");
    Console.WriteLine("|                                                                    |           |                              |");
    Console.WriteLine("|                                                                    |           |                              |");
    Console.WriteLine("|                                                                    |           |______________________________|");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|_______________________|                    |_______________________|");   
}

void fifthroomDefeat()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|                                                                    |           _______________________________");
    Console.WriteLine("|                                                                    |           |   You defeated the dragon   |");
    Console.WriteLine("|                                                                    |           |                             |");
    Console.WriteLine("|                            ______________                          |           |     1- continue             |");
    Console.WriteLine("|                           |              |                         |           |                             |");
    Console.WriteLine("|                           |   ___ ___    |                         |           |                             |");
    Console.WriteLine("|                           |              |                         |           |_____________________________|");
    Console.WriteLine("|                           |   ========   |                         |");
    Console.WriteLine("|                           |______________|                         |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|_______________________|                    |_______________________|");   
}

void fifthroomFail()
{
    Console.WriteLine("______________________________________________________________________");
    Console.WriteLine("|                                                                    |           __________________________________");
    Console.WriteLine("|                                                                    |           |   You where ate by the dragon   |");
    Console.WriteLine("|                                                                    |           |                                 |");
    Console.WriteLine("|                            ______________                          |           |     1- Play again               |");
    Console.WriteLine("|                           |    _    _    |                         |           |                                 |");
    Console.WriteLine("|                           |   |_|  |_|   |                         |           |                                 |");
    Console.WriteLine("|                           |    ______    |                         |           |_________________________________|");
    Console.WriteLine("|                           |   |______|   |                         |");
    Console.WriteLine("|                           |______________|                         |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|                                                                    |");
    Console.WriteLine("|_______________________|                    |_______________________|"); 
}

void congradulations()
{
        Console.WriteLine("______________________________________________________________________");
        Console.WriteLine("|                                                                    |");
        Console.WriteLine("|                        Congradulations!!!                          |");
        Console.WriteLine("|                    You have beaten the game!                       |");
        Console.WriteLine("|                                                                    |");
        Console.WriteLine("|                   Press Enter to play again                        |");
        Console.WriteLine("|____________________________________________________________________|");
}


//inventory code
void inventoryCode()
{
 switch (inventory)
    {
        case 0:
        inventory0();
        break;

        case 1:
        inventory1();
        break;

        case 2:
        inventory2();
        break;

        default:
        break;
    }   
}

//inventory
void inventory0()
{
    Console.WriteLine("________________________________________________________________________________________________");
    Console.WriteLine("|                  |                  |                  |                  |                  |");
    Console.WriteLine("|                  |                  |                  |                  |                  |");
    Console.WriteLine("|                  |                  |                  |                  |                  |");
    Console.WriteLine("|                  |                  |                  |                  |                  |");
    Console.WriteLine("|                  |                  |                  |                  |                  |");
    Console.WriteLine("|__________________|__________________|__________________|__________________|__________________|");
}

void inventory1()
{
    Console.WriteLine("________________________________________________________________________________________________");
    Console.WriteLine("|                  |                  |                  |                  |                  |");
    Console.WriteLine("|   ___            |                  |                  |                  |                  |");
    Console.WriteLine("|  |   |           |                  |                  |                  |                  |");
    Console.WriteLine("|  |   |======     |                  |                  |                  |                  |");
    Console.WriteLine("|  |___|    | |    |                  |                  |                  |                  |");
    Console.WriteLine("|__________________|__________________|__________________|__________________|__________________|");
}
void inventory2()
{
    Console.WriteLine("________________________________________________________________________________________________");
    Console.WriteLine("|                  |         _        |                  |                  |                  |");
    Console.WriteLine("|   ___            |       _|_|_      |                  |                  |                  |");
    Console.WriteLine("|  |   |           |    0==| | |==0   |                  |                  |                  |");
    Console.WriteLine("|  |   |======     |       | | |      |                  |                  |                  |");
    Console.WriteLine("|  |___|    | |    |       | | |      |                  |                  |                  |");
    Console.WriteLine("|__________________|__________________|__________________|__________________|__________________|");
}