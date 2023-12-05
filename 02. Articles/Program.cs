

// Read initial article
string[] initialInput = Console.ReadLine().Split(", ");
Article article = new Article(initialInput[0], initialInput[1], initialInput[2]);

// Read number of commands
int n = int.Parse(Console.ReadLine());

// Process commands
for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split(": ");
    switch (command[0])
    {
        case "Edit":
            article.Edit(command[1]);
            break;
        case "ChangeAuthor":
            article.ChangeAuthor(command[1]);
            break;
        case "Rename":
            article.Rename(command[1]);
            break;
    }
}

// Print final state of the article
Console.WriteLine(article);



