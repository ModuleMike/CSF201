using AboutMe;

string fName = Prompter.ValidString("Enter First Name: ");
string lName = Prompter.ValidString("Enter Last Name: ");
DateTime dOB = Prompter.ValidDateTime("Enter Date of Birth: ");
int age = Prompter.ValidInt("Enter Age: ", 1, 120);
string status = Prompter.ValidChar("Martial Status (S)ingle, (M)arried: ");

Printer.PrintHeader();
Printer.PrintAboutMe(fName, lName, dOB, age, status);
