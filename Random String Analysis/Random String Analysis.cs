//Function of type boolean to detect if a  char exists in  str  string ,Return True if found ,False otherwise
bool isInString(char a, string str)
{
    bool is_found = false;
    // Search char by char
    for (int i = 0; i < str.Length; i++)
    {
        if (a == str[i])
        {
            is_found = true;
            break;
        }
    }
    return is_found;
}

// Declaration of variable array type and initialise each one of them
int[] arr_distinct_chars_1 = new int[80];
int[] arr_distinct_chars_2 = new int[80];
int[] arr_length = new int[80];
string[] arr_str1 = new string[80];
string[] arr_str2 = new string[80];

int[] user_answer_chars_1 = new int[100];
int[] user_answer_chars_2 = new int[100];
int[] user_answer_length = new int[100];

int[] user_result = new int[100];

// Initialize random number generator
Random random = new Random();

// Define accepted characters
string accepted_chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.,?!#";

int questions = 0;

// Print some info about the device which the homework was done on
Console.WriteLine();

// Prompt the user to enter the maximum number of questions
Console.WriteLine("Please enter the maximum number of questions");
questions = int.Parse(Console.ReadLine());

// Ensure the number of questions is between 1 and 80
while (questions < 1 || questions > 80)
{
    Console.WriteLine("The number of questions should be an integer between 1 and 99, please enter it again:");
    questions = int.Parse(Console.ReadLine());
}

// Empty strings to store distinct characters and user input
string distinct_chars = "";
string input = "";

// Continue looping until there are atleast 6 distinct characters
while (distinct_chars.Length < 6)
{
    distinct_chars = "";
    // Prompt the user to enter their name and ID
    Console.WriteLine("Please enter your name <first name and last name> and your SVU id number and ... with a space between each part <Accepted Chars: A-Z a-z 0-9>\nThe entered text should contain at least 2 of Accepted chars.");
    input = Console.ReadLine();

    // Extract distinct characters from the input
    for (int i = 0; i < input.Length; i++)
    {
        // Check if the character is an accepted character and is not already in distinct_chars
        if (isInString(input[i], accepted_chars) && !isInString(input[i], distinct_chars))
        {
            distinct_chars += input[i];
        }
    }
}

// Output the user's full name, ID, and distinct characters
Console.WriteLine("Your full name and id and ...: " + input);
Console.WriteLine("Distinct Chars are: " + distinct_chars);

// Loop through the number of questions
for (int k = 0; k < questions; k++)
{
    int size = 0;
    // Ensure the size of the random strings is between 20 and 80
    while (size < 20 || size > 80)
    {
        Console.WriteLine("Enter the size of the random strings (the size should be between 20 and 80 only!): ");
        size = int.Parse(Console.ReadLine());
    }

    // Generate random strings of the specified size
    for (int i = 0; i < size; i++)
    {
        arr_str1[k] += accepted_chars[random.Next(67)];
        arr_str2[k] += accepted_chars[random.Next(67)];
    }
    // Initialize empty strings to store distinct characters for the random strings
    string distinct_chars_1 = "";
    string distinct_chars_2 = "";

    // Extract distinct characters from the first random string
    for (int i = 0; i < arr_str1[k].Length; i++)
    {
        if (isInString(arr_str1[k][i], accepted_chars) && !isInString(arr_str1[k][i], distinct_chars_1))
        {
            distinct_chars_1 += arr_str1[k][i];
        }
    }

    // Extract distinct characters from the second random string
    for (int i = 0; i < arr_str2[k].Length; i++)
    {
        if (isInString(arr_str2[k][i], accepted_chars) && !isInString(arr_str2[k][i], distinct_chars_2))
        {
            distinct_chars_2 += arr_str2[k][i];
        }
    }

    // Store the number of distinct characters and the length of the random strings
    arr_distinct_chars_1[k] = distinct_chars_1.Length;
    arr_distinct_chars_2[k] = distinct_chars_2.Length;
    arr_length[k] = arr_str1[k].Length + arr_str2[k].Length;

    // Display the generated random strings
    Console.WriteLine("The First string is: " + arr_str1[k]);
    Console.WriteLine("The Second string is: " + arr_str2[k]);

    // Prompt the user to enter the number of distinct characters in the first string
    Console.WriteLine("Enter the number of distinct chars in the first string: ");
    string answer = Console.ReadLine();
    if (answer.ToUpper() == "IGNORE") continue;
    user_answer_chars_1[k] = int.Parse(answer);

    // Prompt the user to enter the number of distinct characters in the second string
    Console.WriteLine("Enter the number of distinct chars in the second string: ");
    answer = Console.ReadLine();
    if (answer.ToUpper() == "IGNORE") continue;
    user_answer_chars_2[k] = int.Parse(answer);

    // Prompt the user to enter the combined length of the two strings
    Console.WriteLine("Enter the length of the two strings: ");
    answer = Console.ReadLine();
    if (answer.ToUpper() == "IGNORE") continue;
    user_answer_length[k] = int.Parse(answer);

    // Initialize user result for the current question
    user_result[k] = 0;

    // Check the user's answers and update the result
    if (user_answer_chars_1[k] == arr_distinct_chars_1[k])
    {
        user_result[k]++;
    }
    if (user_answer_chars_2[k] == arr_distinct_chars_2[k])
    {
        user_result[k]++;
    }
    if (user_answer_length[k] == arr_length[k])
    {
        user_result[k]++;
    }
}

// Loop to display user statistics and options
string user_ans = "";
while (user_ans != "5")
{
    Console.WriteLine("1- Show the number of completely false answers.");
    Console.WriteLine("2- Show the number of completely true answers.");
    Console.WriteLine("3- Show the number of partially true answers.");
    Console.WriteLine("4- Show the User's statistics.");
    Console.WriteLine("5- Exit");
    user_ans = Console.ReadLine();

    int counter = 0;
    // Handle user's choice
    if (user_ans == "1")
    {
      for (int k = 0; k < questions; k++)
        {
            if (user_result[k] == 0) counter++;
        }
        Console.WriteLine("The number of completely false answers is: " + counter);
    }
    else if (user_ans == "2")
    {
       for (int k = 0; k < questions; k++)
        {
            if (user_result[k] == 3) counter++;
        }
        Console.WriteLine("The number of completely true answers is: " + counter);
    }
    else if (user_ans == "3")
    {
        for (int k = 0; k < questions; k++)
        {
            if (user_result[k] == 1 || user_result[k] == 2) counter++;
        }
        Console.WriteLine("The number of partially true answers is: " + counter);
    }
    else if (user_ans == "4")
    {
        for (int k = 0; k < questions; k++)
        {
            Console.WriteLine("User's answers for question[" + k + "]: ");
            Console.WriteLine(user_answer_chars_1[k] + " " + user_answer_chars_2[k] + " " + user_answer_length[k]);
            Console.WriteLine("Correct answers for question[" + k + "]: ");
            Console.WriteLine(arr_distinct_chars_1[k] + " " + arr_distinct_chars_2[k] + " " + arr_length[k]);

            Console.Write("Is the user's answer completely true? ");
            if (user_result[k] == 3)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
