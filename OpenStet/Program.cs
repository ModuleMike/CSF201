using TheLockedDoor;

Door newDoor = new Door(Prompt.SetPasscode());

while (true)
{
    Prompt.CurrentDoorStatus(newDoor._Open, newDoor._Unlocked);
    string Request = Prompt.RequestDoorPrompt();

    switch (Request)
    {
        case "open":
            newDoor.RequestOpen();
            break;
        case "close":
            newDoor.RequestClose();
            break;
        case "lock":
            newDoor.RequestLock();
            break;
        case "unlock":
            newDoor.RequestUnlock();
            break;
    }
}